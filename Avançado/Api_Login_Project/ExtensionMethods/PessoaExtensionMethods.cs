using Api_Login_Project.Contracts;
using Api_Login_Project.Models;

namespace Api_Login_Project.ExtensionMethods
{
    public static class PessoaExtensionMethods
    {
        public static PessoaModel ConvertPessoa(this PessoaModelContract pessoa)
        {
            PessoaModel pess = new();
            pess.Email = pessoa.Email;
            pess.Senha = pessoa.Senha;

            return pess;
        }
    }
}
