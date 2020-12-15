using Microsoft.Extensions.DependencyInjection;
using Tree.WEB.Services.Abstract;
using Tree.WEB.Services.Concrete;

namespace Tree.WEB.Modules
{
    public static class ServicesModule
    {
        public static void AddServicesModule(this IServiceCollection services)
        {
            services.AddScoped<IService, Service>();
        }
    }
}
