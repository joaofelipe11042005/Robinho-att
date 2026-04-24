using System;
using System.Collections.Generic;
using System.Text;

namespace ex_5_classe_hospedes
{
    internal class hospede
    {
        public string nome;
        public double cpf;
        public double telefone;

        public void Receberdados()
        {   
            Console.WriteLine("Digite o nome do hóspede:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do hóspede:");
            cpf = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o telefone do hóspede:");
            telefone = Convert.ToDouble(Console.ReadLine());
        }
        public void MostrarDados()
        {
            Console.WriteLine("Nome do hóspede: " + nome);
            Console.WriteLine("CPF do hóspede: " + cpf);
            Console.WriteLine("Telefone do hóspede: " + telefone);
        }
        public void AtualizarTelefone(string NovoTelefone)
        {
            telefone = Convert.ToDouble(NovoTelefone);
            Console.WriteLine("Telefone atualizado com sucesso!");
        }
    }
}
