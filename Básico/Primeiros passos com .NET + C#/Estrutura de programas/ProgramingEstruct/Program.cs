using System;

namespace ProgramingEstruct
{
    class Program
    {
        static void Main(string[] args)
        {
            var pilha = new Pilha();
            pilha.Empilha(1);
            pilha.Empilha(10);
            pilha.Empilha(100);
            Console.WriteLine(pilha.Desempilha());
            Console.WriteLine(pilha.Desempilha());
            Console.WriteLine(pilha.Desempilha());
            Console.WriteLine("Precione qualquer tecla para proceguir");
            Console.ReadKey();
        }
    }
}
