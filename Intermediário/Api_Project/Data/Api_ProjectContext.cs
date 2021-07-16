using Microsoft.EntityFrameworkCore;

namespace Api_Project.Data
{
    public class Api_ProjectContext : DbContext
    {
        public Api_ProjectContext(DbContextOptions<Api_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Api_Project.Models.ProdutoModel> ProdutoModel { get; set; }

        public DbSet<Api_Project.Models.VendaModel> VendaModel { get; set; }
    }
}
