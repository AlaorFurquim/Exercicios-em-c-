using System;

namespace Controle_Posto_Combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digte o código do combustivel e a quatidade abastecidos");

            int Acool = 0;
            int Gasolina = 0;
            int Disel = 0;
            int Codigo = int.Parse(Console.ReadLine());
            while (Codigo != 4) 
            {
                if (Codigo == 1)
                {
                    Acool = Acool + 1;

                }else if(Codigo == 2)
                {
                    Gasolina = Gasolina + 1;
                }
                else if (Codigo == 3)
                {
                    Disel = Disel + 1;
                }
                 Codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito obrigado!");
            Console.WriteLine("Alcool: " + Acool);
            Console.WriteLine("Gasolina: " + Gasolina);
            Console.WriteLine("Disel: " + Disel);
        }
    }
}
