using EduPrime.Application;
using EduPrime.Infrastructure;
using EduPrime.Infrastructure.Data;
using EduPrime.Infrastructure.Filters;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options =>
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

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
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

builder.Services.AddProblemDetails();
builder.Services.AddResponseCaching();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Dependency injection modules
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

// JWT Authentication settings
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(jwt =>
{
    byte[] secretKey = Encoding.ASCII.GetBytes(builder.Configuration.GetSection("JwtSettings:Secret").Value);

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
        ValidIssuer = builder.Configuration["JwtSettings:Issuer"],

        // Change to true in production envs.
        // If the client (audience) receive the token, that client can not re-use it in any other place.
        ValidateAudience = true,
        ValidAudience = builder.Configuration["JwtSettings:Audience"],

        // Sets token expiration time
        RequireExpirationTime = false,

        // Validates the life time of the token
        ValidateLifetime = true
    };
});

builder.Services.AddCors(options => options.AddPolicy("AppCorsPolicy", build =>
{
    build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

app.UseExceptionHandler(); 

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseCors("AppCorsPolicy");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
