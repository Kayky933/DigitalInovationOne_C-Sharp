using System;

namespace Exemplo_Heranca_E_Metodos.Models
{
    public class PessoaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string Rg { get; set; }
        public string Cpf{get;set;}  
        public string Email{get;set;}      
    }
}