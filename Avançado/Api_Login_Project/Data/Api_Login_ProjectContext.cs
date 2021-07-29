using Microsoft.EntityFrameworkCore;

namespace Api_Login_Project.Data
{
    public class Api_Login_ProjectContext : DbContext
    {
        public Api_Login_ProjectContext(DbContextOptions<Api_Login_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Api_Login_Project.Models.PessoaModel> PessoaModel { get; set; }
    }
}
