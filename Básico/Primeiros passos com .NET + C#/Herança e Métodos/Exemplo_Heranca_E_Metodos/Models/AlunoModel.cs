using System.Text.Json;

namespace Exemplo_Heranca_E_Metodos.Models
{
    public class AlunoModel : PessoaModel
    {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public string ExibirDadosAluno(double media)
        {
            string[] dados = {
               $"Nome: {this.Nome}",
               $"Data Nascimento: {this.Data_Nascimento}",
               $"Rg:{this.Rg}",
               $"CPF:{this.Cpf}",
               $"Email:{this.Email}",
               $"Media:{media}"
            };
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(dados, options);

            return jsonString;
        }
    }
}