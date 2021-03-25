using System;

namespace Hora_Jogadas
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Digite a hora que iniciou e logo após a hora que saiu do game!");
            string[] Hora = Console.ReadLine().Split(' ');

            double Inicio = double.Parse(Hora[0]);
            double Termino = double.Parse(Hora[1]);
            double Duracao;
            if (Inicio < Termino)
            {
                 Duracao = Termino - Inicio;
            }
            else
            {
                 Duracao = 24 - Inicio + Termino;
            }

            Console.WriteLine("Tempo jogado é: " + Duracao + " Horas");




        }
    }
}
