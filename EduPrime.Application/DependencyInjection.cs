using EduPrime.Application.Professors.Interfaces;
using EduPrime.Application.Professors.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace EduPrime.Application
{
    /// <summary>
    /// Dependency injection module for Application Layer
    /// </summary>
    public static  class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IProfessorService, ProfessorService>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddMediatR(options => 
                options.RegisterServicesFromAssemblyContaining(typeof(DependencyInjection))
            );

            return services;
        }
    }
}
