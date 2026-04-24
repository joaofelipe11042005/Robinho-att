using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace exercicio6_classe
{
    internal class Entrega
    {
        public string Endereco { get; set; }
        private double distanciaKm { get; set; }
        public string TipoEntrega { get; set; }
        public double DistanciaKm { 
        get { return distanciaKm; }
            set {
                if (value >= 0) 
                    distanciaKm = value;
            }
        }
        public Entrega(string endereco, double distanciaKm, string tipoEntrega)
        {
            Endereco = endereco;
            DistanciaKm = distanciaKm;
            TipoEntrega = tipoEntrega;
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"Distância (km): {DistanciaKm}");
            Console.WriteLine($"Tipo de Entrega: {TipoEntrega}");
        }
        public double CalcularTaxaEntrega()
        {
            if (TipoEntrega != null && TipoEntrega.ToLower() == "expressa")
                return DistanciaKm * 2.50;
            return DistanciaKm * 1.00;
        }

    }
}
