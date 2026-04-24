using System;
using System.Collections.Generic;
using System.Text;

namespace ex_5_classe_hospedes
{
    internal class reserva
    {
        public string NumeroReserva;
        public int QuantidadeDiarias;
        public double ValorDiaria;
        public double ValorTotal;

        public void ReceberDadosReserva()
        {
            Console.Write("\nNúmero da reserva: ");
            NumeroReserva = Console.ReadLine();

            Console.Write("Quantidade de diárias: ");
            QuantidadeDiarias = int.Parse(Console.ReadLine());

            Console.Write("Valor da diária: R$ ");
            ValorDiaria = double.Parse(Console.ReadLine());
        }

        public void CalcularTotal()
        {
            ValorTotal = QuantidadeDiarias * ValorDiaria;
            Console.WriteLine("Valor total calculado: R$ " + ValorTotal.ToString("F2"));
        }

        public void AplicarDesconto(double percentual)
        {
            double desconto = ValorTotal * (percentual / 100);
            ValorTotal -= desconto;
            Console.WriteLine("Desconto de " + percentual + "% aplicado! Novo total: R$ " + ValorTotal.ToString("F2"));
        }

        public void MostrarReserva()
        {
            Console.WriteLine("\n--- Dados da Reserva ---");
            Console.WriteLine("Número da reserva: " + NumeroReserva);
            Console.WriteLine("Quantidade de diárias: " + QuantidadeDiarias);
            Console.WriteLine("Valor da diária: R$ " + ValorDiaria.ToString("F2"));
            Console.WriteLine("Valor total: R$ " + ValorTotal.ToString("F2"));
        }
    }
}
