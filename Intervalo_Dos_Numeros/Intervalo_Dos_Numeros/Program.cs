using System;
using System.Globalization;

namespace Intervalo_Dos_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número!");
            double Number = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (Number <= 25)
            {
                Console.WriteLine("Intervalo é de 0 a 25");
            } else if ( Number <= 50)
            {
                Console.WriteLine("Intervalo é de 25 a 50");
            } else if ( Number <= 75)
            {
                Console.WriteLine("Intervalo é de 50 a 75");
            } else if( Number <= 100)
            {
                Console.WriteLine("Intervalo é de 75 a 100");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
