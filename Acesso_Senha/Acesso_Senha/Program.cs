using System;

namespace Acesso_Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha!");

            int Senha = int.Parse(Console.ReadLine());

            while (Senha != 2002)
            {
                Console.WriteLine("Senha incorrenta");
                 Senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
