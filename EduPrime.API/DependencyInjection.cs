using EduPrime.Api.Services;
using EduPrime.Application;
using EduPrime.Infrastructure;
using EduPrime.Infrastructure.Data;
using EduPrime.Infrastructure.Filters;
using EduPrime.Application.Users.Interfaces;
using EduPrime.Core.Users;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace EduPrime.Api;

/// <summary>
/// Dependency injection module for Api Layer
/// </summary>
public static class DependecyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services, IConfiguration configuration)
    {
        // Configurations
        services.ConfigureControllers();
        services.ConfigureSwagger();
        services.ConfigureDbContext(configuration);
        services.ConfigureAuthentication(configuration);

        services.AddEndpointsApiExplorer();
        services.AddProblemDetails();
        services.AddResponseCaching();
        services.AddHttpContextAccessor();
        services.AddCors();

        // Dependencies
        services.AddScoped<ICurrentUserProvider, CurrentUserProvider>();

        return services;
    }

    private static IServiceCollection ConfigureControllers(this IServiceCollection services)
    {
        services.AddControllers(options =>
        {
            options.CacheProfiles.Add("OneMinuteCache", new CacheProfile
            {
                Duration = 60
            });
            options.CacheProfiles.Add("HalfMinuteCache", new CacheProfile
            {
                Duration = 30
            });
            options.Filters.Add<GlobalExceptionFilter>();
        }).AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

        return services;
    }

    private static IServiceCollection ConfigureSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
            {
                Description = @"
                JWT Authentication using Bearer schema.
                Insert 'Bearer' followed from a space and then your token in the input below.
                Ex. Bearer [yourToken]",
                Name = "Authorization",
                In = ParameterLocation.Header,
                Scheme = "Bearer"
            });
            options.AddSecurityRequirement(new OpenApiSecurityRequirement()
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        },
                        Scheme = "oauth2",
                        Name = "Bearer",
                        In = ParameterLocation.Header
                    },
                    new List<string>()
                }
            });
        });
        return services;
    }

    private static IServiceCollection ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
        return services;
    }

    private static IServiceCollection ConfigureAuthentication(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(jwt =>
        {
            byte[] secretKey = Encoding.ASCII.GetBytes(configuration.GetSection("JwtSettings:Secret").Value);

            jwt.SaveToken = true;
            jwt.TokenValidationParameters = new TokenValidationParameters()
            {
                // Always validate the secret key that is on the token
                ValidateIssuerSigningKey = true,

                // The key that we get must be equal to the key that we have created in the issuer
                IssuerSigningKey = new SymmetricSecurityKey(secretKey),

                // Change to true in production envs.
                // It validates that the ORIGINAL issuer is the one that emit the token.
                // Ensures that there is not another source that emit the token.
                ValidateIssuer = true,
                ValidIssuer = configuration["JwtSettings:Issuer"],

                // Change to true in production envs.
                // If the client (audience) receive the token, that client can not re-use it in any other place.
                ValidateAudience = true,
                ValidAudience = configuration["JwtSettings:Audience"],

                // Sets token expiration time
                RequireExpirationTime = false,

                // Validates the life time of the token
                ValidateLifetime = true
            };
        });
        return services;
    }

    private static IServiceCollection ConfigureCors(this IServiceCollection services)
    {
        services.AddCors(options => options.AddPolicy("AppCorsPolicy", build =>
        {
            build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
        }));
        return services;
    }
}
