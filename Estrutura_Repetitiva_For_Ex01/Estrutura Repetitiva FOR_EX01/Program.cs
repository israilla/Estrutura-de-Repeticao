using System;

namespace Estrutura_Repetitiva_FOR_EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++)
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            Console.ReadKey();    
        }
    }
}
