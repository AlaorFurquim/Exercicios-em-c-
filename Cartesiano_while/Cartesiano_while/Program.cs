using System;

namespace Cartesiano_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os pontos");

            string[] Ponto = Console.ReadLine().Split(' ');

            int x = int.Parse(Ponto[0]);
            int y = int.Parse(Ponto[1]);

            while (x != 0 || y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }else if ( x < 0 && y > 0)
                {
                    Console.WriteLine("Terceiro");
                }else if( x > 0 && y < 0)
                {
                    Console.WriteLine("Quarto");
                } else
                {
                    Console.WriteLine();
                }
                Ponto = Console.ReadLine().Split(' ');
                x = int.Parse(Ponto[0]);
                y = int.Parse(Ponto[1]);
            }
        }
    }
}
