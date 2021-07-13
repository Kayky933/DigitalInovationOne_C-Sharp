using Microsoft.EntityFrameworkCore;

namespace MVC_Project.Data
{
    public class MVC_ProjectContext : DbContext
    {
        public MVC_ProjectContext(DbContextOptions<MVC_ProjectContext> options)
            : base(options)
        {
        }


        public DbSet<MVC_Project.Models.VendaModel> Vendas { get; set; }
        public DbSet<MVC_Project.Models.ProdutoModel> Produtos { get; set; }
    }
}
