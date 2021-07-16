using Api_Project.Interfaces.Repository;
using Api_Project.Interfaces.Service;
using Api_Project.Repository;
using Api_Project.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Api_Project.StartUpConfigure
{
    public class StartUpConfiguration
    {
        public static void ConfigureDependencyInjection(IServiceCollection services)
        {
            services.AddScoped<IProdutoService, ProdutoService>();

            services.AddScoped<IProdutoRepository, ProdutoRepository>();
        }
    }
}
