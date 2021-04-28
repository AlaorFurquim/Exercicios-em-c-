using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aluguel_De_Carros
{
    class AluguelDeCarro
    {
        public string Nome { get; private set; }
        public int Veiculo { get; set; }
        public double Cpf { get; private set; }
        public double Date { get; private set; }
        public double Total { get;  set; }
        public double Dia { get; set; }
        public int Fox { get; set; }

        public AluguelDeCarro(string nome, double cpf, double date)
        {
            Nome = nome;
            Cpf = cpf;
            Date = date;
            
        }
        public AluguelDeCarro(string nome, int veiculo,double cpf, double date, double total, double dia) : this(nome, cpf, date)
        {
            Total = total;
            Dia = dia;
            Veiculo = veiculo;
        }


        

        public override string ToString()
        {
            return "Cliente: "
                + Nome
                + ", "
                + "Nascimento: "
                + Date
                + ", "
                + "Cpf: "
                + Cpf
                + ", "
                + "Total a pagar: "
                + ", "
                + Total.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
