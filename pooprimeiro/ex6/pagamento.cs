using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio6_classe
{
    internal class Pagamento
    {
        public string FormaDePagamento { get; set; }
        private int parcelas;
        public int Parcelas
        {
            get { return parcelas; }
            set
            {
                if (value >= 1)
                    parcelas = value;
            }
        }
        public Pagamento(string formaPagamento, int parcelas)
        {
            FormaDePagamento = formaPagamento;
            Parcelas = parcelas;
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Forma de Pagamento: {FormaDePagamento}");
            Console.WriteLine($"Parcelas: {Parcelas}");
        }
        public bool ValidarPagamento()
        {
            if (FormaDePagamento == "" || FormaDePagamento == null)
                return false;

            if (parcelas < 1)
                return false;

            return true;
        }
            public double CalcularAcrescimo(double valorBase)
        {
            if (Parcelas <= 1)
                return 0;
            return valorBase * (Parcelas - 1) * 0.02;

        }
    }
}