using Projeto_MVC_Curso.Models.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace Projeto_MVC.Models
{
    public class EnderecoModel
    {
        [Key]
        public Guid Endereco_Id { get; set; }
        [StringLength(9, ErrorMessage = "o campo Cep deve ter 9 apenas caracteres")]
        [Required(ErrorMessage = "Informe o Cep", AllowEmptyStrings = false)]
        public string Cep { get; set; }

        [MaxLength(80, ErrorMessage = "o campo Logradouro suporte no máximo 80 caracteres")]
        [Required(ErrorMessage = "Informe o Logradouro", AllowEmptyStrings = false)]
        public string Logradouro { get; set; }

        [MaxLength(80, ErrorMessage = "o campo Complemento suporte no máximo 80 caracteres")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Informe o Número")]
        public int Numero { get; set; }

        [MaxLength(80, ErrorMessage = "o campo Bairro suporte no máximo 80 caracteres")]
        [Required(ErrorMessage = "Informe o Bairro", AllowEmptyStrings = false)]
        public string Bairro { get; set; }

        [MaxLength(80, ErrorMessage = "o campo Localidade suporte no máximo 80 caracteres")]
        [Required(ErrorMessage = "Informe a Localidade", AllowEmptyStrings = false)]
        public string Localidade { get; set; }
        public UnidadeFederalEnum Uf { get; set; }
    }
}