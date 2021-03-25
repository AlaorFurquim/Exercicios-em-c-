using System;
using System.Globalization;

namespace Plano_Cartesiano
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira cordenada x");
            double X = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda cordenada y");
            double Y = double.Parse(Console.ReadLine());
            

            if (X == 0.0 && Y == 0.0)
            {
                Console.WriteLine("Ponto se encontra na origem!");
            }
            else if (X == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (Y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }



            else if (X > 0.0 && Y > 0.0)
            {
                Console.WriteLine("Ponto no Q1");
            }
            else if (X < 0.0 && Y > 0.0)
            {
                Console.WriteLine("Ponto no Q2");
            }
            else if (X < 0.0 && Y < 0.0)
            {
                Console.WriteLine("Ponto no Q3");
            }
            else
            {
                Console.WriteLine("Ponto no Q4");
            }


        }
    }
}
