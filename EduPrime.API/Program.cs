using EduPrime.Api.Helpers;
using EduPrime.Api.Services;
using EduPrime.Infrastructure.AzureServices;
using EduPrime.Infrastructure.Data;
using EduPrime.Infrastructure.Filters;
using EduPrime.Infrastructure.MailService;
using EduPrime.Infrastructure.Repository;
using EduPrime.Infrastructure.Security;
using EduPrime.Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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
builder.Services.AddSwaggerGen();
builder.Services.AddResponseCaching();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<ISubjectService, SubjectService>();
builder.Services.AddTransient<IStudentService, StudentService>();
builder.Services.AddTransient<IFileHelper, FileHelper>();
builder.Services.AddTransient<IJwtFactory, JwtFactory>();
builder.Services.AddTransient<IEmployeeRepositoryService, EmployeeRepositoryService>();

// Password service settings
builder.Services.Configure<PasswordSettings>(builder.Configuration.GetSection("PasswordSettings"));
builder.Services.AddTransient<IPasswordHasher, PasswordHasher>();

// Email service settings
builder.Services.Configure<SmtpSettings>(builder.Configuration.GetSection("SmtpSettings"));
builder.Services.AddScoped<IEmailSender, EmailService>();

// Azure settings
builder.Services.Configure<AzureSettings>(builder.Configuration.GetSection("azureSettings"));
builder.Services.AddSingleton<IBlobStorageService, BlobStorageService>();

// AutoMapper settings
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// JWT Authentication settings
builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));
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

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseCors("AppCorsPolicy");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
