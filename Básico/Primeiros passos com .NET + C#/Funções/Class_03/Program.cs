using System;
using Functions;

namespace Class_o3
{
     class Program
    {
        static void Main()
        {
            string[] stringArray = new string[]{"argumento 1","argumento 2","argumento 3","argumento 4"};                 
            var Funcoes = new FunctionsClass();
           Funcoes.Declaracoes();
           Console.WriteLine("-------------");
           Funcoes.InstrucaoIf(stringArray);
           Console.WriteLine("-------------");
           Funcoes.InstrucaoSwitch(stringArray);
           Console.WriteLine("-------------");
           Funcoes.InstrucaoWhile(stringArray);
           Console.WriteLine("-------------");
           Funcoes.InstrucaoDo(stringArray);
           Console.WriteLine("-------------");
           Funcoes.InstrucaoFor(stringArray);
           Console.WriteLine("-------------");
           Funcoes.InstrucaoForeach(stringArray);
           Console.WriteLine("-------------");
           Funcoes.InstrucaoBreak(stringArray);
           Console.WriteLine("-------------");
           Funcoes.InstrucaoContinue(stringArray);
           Console.WriteLine("-------------");
           Funcoes.InstrucaoReturn(stringArray);
           Console.WriteLine("-------------");
           Funcoes.InstrucoesTryCatchFinallyThrow(stringArray);
           Console.WriteLine("-------------");
           Funcoes.InstrucaoUsing(stringArray);
        }
    }
        
}