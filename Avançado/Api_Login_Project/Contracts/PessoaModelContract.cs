using System.ComponentModel.DataAnnotations;

namespace Api_Login_Project.Contracts
{
    public class PessoaModelContract
    {
        [MinLength(7, ErrorMessage = "O campo Email tem o tamanho mínimo de 7 caracteres")]
        [MaxLength(100, ErrorMessage = "O campo Email tem o tamanho máximo de 100 caracteres")]
        [Required(ErrorMessage = "O campo Email é obrigatório", AllowEmptyStrings = false)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [MinLength(8, ErrorMessage = "A Senha deve ter no mínimo 8 caracteres")]
        [MaxLength(100, ErrorMessage = "O campo Senha tem o tamanho máximo de 100 caracteres")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "O campo Senha é obrigatório", AllowEmptyStrings = false)]
        public string Senha { get; set; }
    }
}
