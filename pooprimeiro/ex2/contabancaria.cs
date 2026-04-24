using System;
using System.Collections.Generic;
using System.Text;

namespace ex_2_conta_bancaria
{
    internal class contabancaria
    {
        public string NumeroConta;
        public string NomeTitular;
        public double Saldo;

        public void ReceberDados()
        {
            Console.WriteLine("Digite o número da conta: ");
            NumeroConta = Console.ReadLine();
            Console.WriteLine("Digite o nome do titular: ");
            NomeTitular = Console.ReadLine();
            Console.WriteLine("Digite o saldo inicial: ");
            Saldo = double.Parse(Console.ReadLine());
        }
        public void Depositar()
        {
            Console.WriteLine("Digite o valor a ser depositado: ");
            Double valor = double.Parse(Console.ReadLine());
            Saldo += valor;
            Console.WriteLine("Valor depositado com sucesso!");
        }
        public void Sacar()
        {
            Console.WriteLine("Digite o valor a ser sacado: ");
            Double valor = double.Parse(Console.ReadLine());
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine("Valor sacado com sucesso!");
            }
        }
        public void mostrarsaldo()
        {
            Console.WriteLine("Número da conta: " + NumeroConta);
            Console.WriteLine("Nome do titular: " + NomeTitular);
            Console.WriteLine("Saldo atual: R$ " + Saldo);
        }
    }
}
