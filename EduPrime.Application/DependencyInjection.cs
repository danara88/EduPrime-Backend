using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using EduPrime.Application.Common.Behaviors;
using EduPrime.Application.Professors.Interfaces;
using EduPrime.Application.Professors.Services;
using EduPrime.Application.Subjects.Interfaces;
using EduPrime.Application.Subjects.Services;

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
            services.AddScoped<ISubjectService, SubjectService>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddMediatR(options =>{
                // Add commands/queries from the current assembly (Application layer)
                options.RegisterServicesFromAssemblyContaining(
                    typeof(DependencyInjection));

                // Add generic behavior for validation
                options.AddOpenBehavior(typeof(ValidationBehavior<,>));
            });

            // Register all the validators IValidator<T> from the current assembly (Application layer)
            services.AddValidatorsFromAssemblyContaining(typeof(DependencyInjection));

            return services;
        }
    }
}
