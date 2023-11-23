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
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddMediatR(options => 
                options.RegisterServicesFromAssemblyContaining(typeof(DependencyInjection))
            );

            return services;
        }
    }
}
