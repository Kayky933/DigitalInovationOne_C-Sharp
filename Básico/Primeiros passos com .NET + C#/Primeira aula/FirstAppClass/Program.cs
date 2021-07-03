using System;

namespace FirstAppClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Welcome to .NET class {i}");
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
