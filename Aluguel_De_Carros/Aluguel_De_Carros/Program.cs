using System;
using System.Globalization;

namespace Aluguel_De_Carros
{
    class Program
    {
        static void Main(string[] args)
        {
            AluguelDeCarro cliente;
            Console.WriteLine("Digite o nome do cliente!");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a data de nascimento!");
            double date = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o cpf!");
            double cpf = double.Parse(Console.ReadLine());

            double total;

            Console.WriteLine();

            cliente  = new AluguelDeCarro(nome, cpf,date);

            
            Console.WriteLine(cliente);

            Console.WriteLine();

            Console.WriteLine("Digite a quantidade de dias que o cliente ira ficar com o carro!");
            double dia = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o carro que o cliente vai pegar?");
           
            string veiculo = Console.ReadLine();

            if (veiculo == "Fox" || veiculo == "fox"){ 
                
                total = 150.00 * dia;

                Console.WriteLine(total);

            } 
            else if(veiculo == "Gol"|| veiculo == "gol" ){

                total = 200.00 * dia;

                Console.WriteLine(total);
            }
            else if (veiculo == "Hilux" || veiculo == "hilux")
            {

                total = 500.00 * dia;

                Console.WriteLine(total);
            }
            else if (veiculo == "Land Rouver" || veiculo == "land rouver")
            {
                total = 700.00 * dia;

                Console.WriteLine(total);
            }
            else 
            {

                Console.WriteLine("Não possuimos este veiculo!");
            }
        }

    }
    
}
