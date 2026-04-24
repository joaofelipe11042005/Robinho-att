using System;
using System.Collections.Generic;
using System.Text;

namespace ex_4_calculadora_de_salario
{
    internal class CalculadoraDeSalario
    {
        public string NomeFuncionario;
        public double SalarioBase;
        public double SalarioFinal;

        public void ReceberDados()
        {
            Console.Write("Nome do funcionário: ");
            NomeFuncionario = Console.ReadLine();

            Console.Write("Salário base: ");
            SalarioBase = double.Parse(Console.ReadLine());

            SalarioFinal = SalarioBase;
        }

        public void CalcularAumento(double percentual)
        {
            double aumento = SalarioFinal * (percentual / 100);
            SalarioFinal += aumento;
            Console.WriteLine("Aumento de " + percentual + "% aplicado com sucesso!");
        }

        public void CalcularDesconto(double percentual)
        {
            double desconto = SalarioFinal * (percentual / 100);
            SalarioFinal -= desconto;
            Console.WriteLine("Desconto de " + percentual + "% aplicado com sucesso!");
        }

        public void MostrarSalario()
        {
            Console.WriteLine("\n--- Dados do Funcionário ---");
            Console.WriteLine("Nome: " + NomeFuncionario);
            Console.WriteLine("Salário base: R$ " + SalarioBase.ToString("F2"));
            Console.WriteLine("Salário final: R$ " + SalarioFinal.ToString("F2"));
        }
    }
}
