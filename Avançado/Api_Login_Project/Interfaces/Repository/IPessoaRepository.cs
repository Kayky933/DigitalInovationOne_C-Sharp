using Api_Login_Project.Models;

namespace Api_Login_Project.Interfaces.Repository
{
    public interface IPessoaRepository : IBaseRepository<PessoaModel>
    {
        public PessoaModel GetBySenha(string senha);
        public PessoaModel Login(PessoaModel model);
    }
}
