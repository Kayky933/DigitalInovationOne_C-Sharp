using System;
using System.Collections.Generic;
using Exemplo_Heranca_E_Metodos.Models;

namespace Exemplo_Heranca_E_Metodos.Metodos
{
    public class MetodosProfessor
    {
        public static void CadastraProfessor(ProfessorModel prof)
        {
            List<ProfessorModel> ListProf = new List<ProfessorModel>();

            Console.WriteLine("Qual seu nome?");
            prof.Nome = Console.ReadLine();

            Console.WriteLine("Qual sua Data de nascimento?");
            prof.Data_Nascimento = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Digite seu Rg?");
            prof.Rg = Console.ReadLine();

            Console.WriteLine("Digite seu Cpf?");
            prof.Cpf = Console.ReadLine();

            Console.WriteLine("informe seu E-mail?");
            prof.Email = Console.ReadLine();

            Console.WriteLine("Qual sua Materia?");
            prof.Materia = Console.ReadLine();

            Console.WriteLine("Qual a sala que você da aula?");
            prof.Sala = Console.ReadLine();

            ListProf.Add(prof);

            foreach (ProfessorModel professor in ListProf)
            {
                Console.Clear();
                Console.WriteLine("Cadastro:\n" + prof.ExibiDadosProfessro());
            }
        }
    }
}