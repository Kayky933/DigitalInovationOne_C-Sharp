using Api_Login_Project.Contracts;
using Api_Login_Project.Models;

namespace Api_Login_Project.Interfaces.Service
{
    public interface IPessoaService : IBaseService<PessoaModel>
    {
        public PessoaModelContract Create(PessoaModelContract model);
        public PessoaModelContract Login(PessoaModelContract model);
    }
}
