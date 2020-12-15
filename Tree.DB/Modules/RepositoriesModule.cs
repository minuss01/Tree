using Microsoft.Extensions.DependencyInjection;
using Tree.DB.Repositories.Abstract;
using Tree.DB.Repositories.Concrete;

namespace Tree.DB.Modules
{
    public static class RepositoriesModule
    {
        public static void AddRepositoriesModule(this IServiceCollection services)
        {
            services.AddSingleton<ICompositeRepository, CompositeRepository>();
            services.AddSingleton<ILeafRepository, LeafRepository>();
        }
    }
}
