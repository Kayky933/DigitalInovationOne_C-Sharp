using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Login_Project.Models
{
    [Table("Pessoa")]
    public class PessoaModel
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
