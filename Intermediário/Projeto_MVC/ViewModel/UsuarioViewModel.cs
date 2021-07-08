using Projeto_MVC_Curso.Models.Enum;
using System;

namespace Projeto_MVC.ViewModel
{
    public class UsuarioViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }
        public Guid Endereco_Id { get; set; }
        public string Cep { get; set; }

        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        public int Numero { get; set; }

        public string Bairro { get; set; }

        public string Localidade { get; set; }
        public UnidadeFederalEnum Uf { get; set; }
    }
}
