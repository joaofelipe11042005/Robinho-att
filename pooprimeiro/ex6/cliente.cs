using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace exercicio6_classe
{
    internal class Cliente
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string cidade { get; set; }
        public Cliente(string nome, string cpf, string cidade)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.cidade = cidade;
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"CPF: {cpf}");
            Console.WriteLine($"Cidade: {cidade}");
        }
        public string RetornarApresentacao()
        {
            return $"Nome: {nome}, CPF: {cpf}, Cidade: {cidade}";
        }
    }
}
