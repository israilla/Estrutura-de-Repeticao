using System;
using System;

namespace Structure_Repetitive_EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua senha!");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Ivalida");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido");
            Console.ReadKey();
        }
    }
}
