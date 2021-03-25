using System;
using System.Globalization;

namespace Toral_A_Pagar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o código e a quantidade!");

            int Codigo = int.Parse(Console.ReadLine());
            int Quantidade = int.Parse(Console.ReadLine());
            double Total;

            if (Codigo == 1)
            {
                Total = Quantidade * 4;
            }
            else if (Codigo == 2)
            {
                Total = Quantidade * 4.50;
            }
            else if (Codigo == 3)
            {
                Total = Quantidade * 5.00;
            }
            else if (Codigo == 4)
            {
                Total = Quantidade * 2.00;

            }
            else 
            {
                Total = Quantidade * 1.50;
            }

            Console.WriteLine("Total a pagar é R$ " + Total.ToString("F2",CultureInfo.InvariantCulture));

            



        }
    }
}
