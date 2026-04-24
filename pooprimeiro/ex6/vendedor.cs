using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace exercicio6_classe
{
    internal class Vendedor
    {
        private string nome;
        private double percentual;

        public string Matricula { get; private set; }

        public string Nome
        {
            get { return nome; }
            set { nome = value; Matricula = nome + "10"; }
        }
       
        public double Percentual
        {
            get { return percentual; }
            set {
                if (value >= 0)
                    percentual = value;
            }
        }
         public Vendedor(string nome, double percentual)
        {
            Nome = nome;
            Percentual = percentual;
        }
         public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Percentual: {percentual.ToString("P", CultureInfo.InvariantCulture)}");
        }
        public double CalcularComissao(double valorPedido)
        {
            return valorPedido * (percentual / 100);
        }

    }
}