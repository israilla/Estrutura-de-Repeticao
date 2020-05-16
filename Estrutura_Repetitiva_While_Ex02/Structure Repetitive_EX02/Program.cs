using System;

namespace Structure_Repetitive_EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com x e y");
            string[] vetor = Console.ReadLine().Split(' ');
            int x = int.Parse(vetor[0]);
            int y = int.Parse(vetor [1]);

            while (x != 0 && y != 0)
            {
                if(x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro Quadrante");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo Quadrante");
                }
                else if (x<0 && y < 0) 
                {
                    Console.WriteLine("Terceiro Quadrante");
                }
                else
                {
                    Console.WriteLine("Quarto Quadrante");
                }
                vetor = Console.ReadLine().Split(' ');
                x = int.Parse(vetor[0]);
                y = int.Parse(vetor[1]);
                Console.ReadKey();
            }
        }
    }
}
