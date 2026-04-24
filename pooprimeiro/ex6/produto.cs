using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio6_classe
{
    internal class Produto
    {
        private double precoUnitario;
        private int quantidade;
        public string Descricao { get; set; }
        public double PrecoUnitario
        {
            get { return precoUnitario; }
            set
            {
                if (value >= 0)
                    precoUnitario = value;
            }
        }
        public int Quantidade
        {
            get { return quantidade; }
            set
            {
                if (value >= 0)
                    quantidade = value;
            }
        }
        public Produto(string descricao, double precoUnitario, int quantidade)
        {
            Descricao = descricao;
            PrecoUnitario = precoUnitario;
            Quantidade = quantidade;
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Descrição: {Descricao}");
            Console.WriteLine($"Preço Unitário: {PrecoUnitario:C}");
            Console.WriteLine($"Quantidade: {Quantidade}");
        }
        public double CalcularSubtotal()
        {
            return PrecoUnitario * Quantidade;
        }
    }
}
