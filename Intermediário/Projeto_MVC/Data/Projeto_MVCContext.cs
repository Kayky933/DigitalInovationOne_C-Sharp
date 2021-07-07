using Microsoft.EntityFrameworkCore;

namespace Projeto_MVC.Data
{
    public class Projeto_MVCContext : DbContext
    {
        public Projeto_MVCContext(DbContextOptions<Projeto_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<Projeto_MVC.Models.UsuarioModel> Usuario { get; set; }
        public DbSet<Projeto_MVC.Models.UsuarioEnderecoModel> UsuarioEndereco { get; set; }
    }
}
