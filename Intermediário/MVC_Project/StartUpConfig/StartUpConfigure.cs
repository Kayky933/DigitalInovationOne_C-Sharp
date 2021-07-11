using Microsoft.Extensions.DependencyInjection;
using MVC_Project.Interfaces.Repository;
using MVC_Project.Interfaces.Service;
using MVC_Project.Repository;
using MVC_Project.Service;

namespace MVC_Project.StartUpConfig
{
    public class StartUpConfigure
    {
        public static void ConfigureDependencyInjection(IServiceCollection services)
        {
            services.AddScoped<IVendaService, VendaService>();
            services.AddScoped<IProdutoService, ProdutoService>();

            services.AddScoped<IVendaRepository, VendaRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
        }
    }
}
