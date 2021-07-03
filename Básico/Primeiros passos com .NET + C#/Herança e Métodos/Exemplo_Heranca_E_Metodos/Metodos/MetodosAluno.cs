using System;
using System.Collections.Generic;
using Exemplo_Heranca_E_Metodos.Models;

namespace Exemplo_Heranca_E_Metodos.Metodos
{
    public class MetodosAluno
    {
        public static void CadastraAluno(AlunoModel al)
        {
            List<AlunoModel> ListAl = new List<AlunoModel>();

            Console.WriteLine("Qual seu nome?");
            al.Nome = Console.ReadLine();

            Console.WriteLine("Qual sua Data de nascimento?");
            al.Data_Nascimento = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Digite seu Rg?");
            al.Rg = Console.ReadLine();

            Console.WriteLine("Digite seu Cpf?");
            al.Cpf = Console.ReadLine();

            Console.WriteLine("informe seu E-mail?");
            al.Email = Console.ReadLine();

            Console.WriteLine("Informe a Primeira nota:");
            al.Nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a Segunda nota:");
            al.Nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a Terceira nota:");
            al.Nota3 = Convert.ToDouble(Console.ReadLine());

            ListAl.Add(al);
            double media = CalcMedia(al.Nota1, al.Nota2, al.Nota3);

            al.ExibirDadosAluno(media);

            foreach (AlunoModel alunos in ListAl)
            {
                Console.Clear();
                Console.WriteLine("Cadastro:\n" + al.ExibirDadosAluno(media));
            }

        }
        public static double CalcMedia(double nota1, double nota2, double nota3)
        {
            double media = (nota1 + nota2 + nota3) / 3;
            return media;
        }
    }
}