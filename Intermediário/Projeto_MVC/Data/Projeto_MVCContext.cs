using Microsoft.EntityFrameworkCore;
using Projeto_MVC.ViewModel;

namespace Projeto_MVC.Data
{
    public class Projeto_MVCContext : DbContext
    {
        public Projeto_MVCContext(DbContextOptions<Projeto_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<Projeto_MVC.Models.UsuarioModel> Usuario { get; set; }
        public DbSet<Projeto_MVC.Models.EnderecoModel> Endereco { get; set; }
        public DbSet<Projeto_MVC.ViewModel.UsuarioViewModel> UsuarioViewModel { get; set; }
    }
}
