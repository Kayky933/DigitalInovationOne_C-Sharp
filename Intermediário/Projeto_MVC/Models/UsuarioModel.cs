using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_MVC.Models
{
    [Table("Pessoa")]
    public class UsuarioModel
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid Id { get; set; }

        [MaxLength(100, ErrorMessage = "o campo Nome suporte no máximo 100 caracteres")]
        [MinLength(3, ErrorMessage = "O campo Nome deve ter no mínimo e caracteres")]
        [Required(ErrorMessage = "o campo Nome não pode ser nulo", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        [MaxLength(100, ErrorMessage = "o campo E-mail suporte no máximo 100 caracteres")]
        [MinLength(7, ErrorMessage = "O campo E-mail não pode ter no mínimo 7 caracteres")]
        [Required(ErrorMessage = "O campo E-mail não pode ser nulo", AllowEmptyStrings = false)]
        public string Email { get; set; }
        [MaxLength(70, ErrorMessage = "O campo Senha suporte no máximo 70 caracteres")]
        [MinLength(8, ErrorMessage = "O campo Senha deve ter no mínimo 8 caracteres")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Informe a senha", AllowEmptyStrings = false)]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Informe a Data de Nascimento", AllowEmptyStrings = false)]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [ForeignKey("Endereco")]
        public Guid Enredeco_Id { get; set; }
        [ScaffoldColumn(false)]
        public EnderecoModel Endereco { get; set; }

    }
}