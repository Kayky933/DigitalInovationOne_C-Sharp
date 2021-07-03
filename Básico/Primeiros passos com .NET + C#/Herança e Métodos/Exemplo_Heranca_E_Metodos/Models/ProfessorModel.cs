using System.Text.Json;

namespace Exemplo_Heranca_E_Metodos.Models
{
    public class ProfessorModel : PessoaModel
    {
        public string Materia { get; set; }
        public string Sala { get; set; }

        public string ExibiDadosProfessro()
        {
            string[] dados = {
               $"Nome: {this.Nome}",
               $"Data Nascimento: {this.Data_Nascimento}",
               $"Rg:{this.Rg}",
               $"CPF:{this.Cpf}",
               $"Email:{this.Email}",
               $"Materia:{this.Materia}",
               $"Sala:{this.Sala}"
            };
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(dados, options);

            return jsonString;
        }
    }
}