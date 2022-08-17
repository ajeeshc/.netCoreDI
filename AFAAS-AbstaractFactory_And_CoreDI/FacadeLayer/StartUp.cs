using Implimentation;
using Microsoft.Extensions.DependencyInjection;

namespace FacadeLayer
{
    public static class StartUp
    {
        public static IServiceCollection AddFacadeService(this IServiceCollection services)
        {
            services.AddStepService();
            services.AddScoped<IFacade, Facade>();
            return services;
        }
    }
}
