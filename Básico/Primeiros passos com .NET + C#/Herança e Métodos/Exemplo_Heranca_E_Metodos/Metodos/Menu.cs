using System;
using Exemplo_Heranca_E_Metodos.Models;

namespace Exemplo_Heranca_E_Metodos.Metodos
{
    public class Menu
    {
        public static void MenuTela(string resp)
        {

            switch (resp)
            {
                case "1":
                    ProfessorModel prof = new ProfessorModel();
                    MetodosProfessor.CadastraProfessor(prof);

                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    AlunoModel al = new AlunoModel();
                    MetodosAluno.CadastraAluno(al);

                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "0":
                    Console.WriteLine("Aperte qualquer tecla para fechar");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Opção inválida, tete novamente");
                    Console.ReadKey();
                    break;
            }
        }
    }
}