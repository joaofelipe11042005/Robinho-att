using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_8_classes
{
    internal class Reserva
    {
        private string _nomeHospede;
        private int _numeroQuarto;

        public string NomeHospede
        {
            get { return _nomeHospede; }
            set { _nomeHospede = value; }
        }
        public int NumeroQuarto
        {
            get { return _numeroQuarto; }
            set { _numeroQuarto = value; }
        }
        public int QuantidadeDeReservas { get; set; }
        public double ValorDaReserva { get; set; }
        public string StatusReserva { get; set; }

        public Reserva(string NomeHospedes, int numeroQuarto)
        {
            NomeHospedes = string.IsNullOrEmpty(NomeHospedes) ? "Hospede não informado" : NomeHospedes;
            numeroQuarto = numeroQuarto <= 0 ? 1 : numeroQuarto;
            QuantidadeDeReservas = 1;
            ValorDaReserva = 50;
            StatusReserva = "Ativa";
        }
        public Reserva(string nomeHospedes, int numeroQuarto, int quantidadeDiarias, double valorDiaria)
        {
            NomeHospede = string.IsNullOrEmpty(nomeHospedes) ? "Hóspede não informado" : nomeHospedes;
            NumeroQuarto = numeroQuarto <= 0 ? 1 : numeroQuarto;
            QuantidadeDeReservas = quantidadeDiarias <= 0 ? 1 : quantidadeDiarias;
            ValorDaReserva = valorDiaria <= 0 ? 50 : valorDiaria;
            StatusReserva = "Ativa";
        }
        public double CalcularTotal()
        {
            return QuantidadeDeReservas * ValorDaReserva;
        }
        public void ExibirReservas()
        {
            Console.WriteLine("===Reservas===");
            Console.WriteLine("Hóspedes: " + NomeHospede);
            Console.WriteLine("Quarto: " + NumeroQuarto);
            Console.WriteLine("Diárias: " + QuantidadeDeReservas);
            Console.WriteLine("Valor da diária: " + ValorDaReserva);
            Console.WriteLine("Status: " + StatusReserva);
            Console.WriteLine("===============");
        }
        public void AdicionarDiarias(int quantidade)
        {
            if (quantidade > 0)
            {
                QuantidadeDeReservas = QuantidadeDeReservas + quantidade;
            }
        }
        public void CancelarReserva()
        {
            StatusReserva = "Cancelada";
        }
        public void ReativarReserva()
        {
            StatusReserva = "Ativa";
        }
    }
}
