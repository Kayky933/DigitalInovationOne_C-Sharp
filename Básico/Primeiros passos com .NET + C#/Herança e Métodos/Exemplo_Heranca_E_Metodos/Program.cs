using System;
using Exemplo_Heranca_E_Metodos.Metodos;

namespace Exemplo_Heranca_E_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp;

            do
            {
                Console.Clear();
                Console.WriteLine("Olá, escolha uma das opções abaixo para \n identificarmos seu registro\n");
                Console.WriteLine("0-Sair\n1-Professor\n2-Aluno");

                resp = Console.ReadLine();
                Menu.MenuTela(resp);
            } while (resp != "0");
        }
    }
}
