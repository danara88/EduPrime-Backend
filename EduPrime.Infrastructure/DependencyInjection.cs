using EduPrime.Application.Common.Interfaces;
using EduPrime.Application.Helpers.Security;
using EduPrime.Infrastructure.AzureServices;
using EduPrime.Infrastructure.Helpers;
using EduPrime.Infrastructure.MailService;
using EduPrime.Infrastructure.Repository;
using EduPrime.Infrastructure.Security;
using EduPrime.Infrastructure.Services;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EduPrime.Infrastructure
{
    /// <summary>
    /// Dependency injection module
    /// </summary>
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IFileHelper, FileHelper>();
            services.AddTransient<IEmployeeRepositoryService, EmployeeRepositoryService>();

            // JWT configuration set up
            services.AddTransient<IJwtFactory, JwtFactory>();
            services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));

            // Password services set up
            services.Configure<PasswordSettings>(configuration.GetSection("PasswordSettings"));
            services.AddTransient<IPasswordService, PasswordService>();

            // Email services set up
            services.Configure<SmtpSettings>(configuration.GetSection("SmtpSettings"));
            services.AddScoped<IEmailSender, EmailService>();

            // Azure services set up
            services.Configure<AzureSettings>(configuration.GetSection("azureSettings"));
            services.AddSingleton<IBlobStorageService, BlobStorageService>();

            // Security services set up
            services.Configure<SecuritySettings>(configuration.GetSection("SecuritySettings"));
            services.AddScoped<ISecurityHelper, SecurityHelper>();

            return services;
        }
    }
}
