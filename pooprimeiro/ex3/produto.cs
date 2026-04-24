using System;
using System.Collections.Generic;
using System.Text;

namespace ex_3_produto
{
    internal class produto
    {
        public string CodigoProduto;
        public string NomeProduto;
        public double Preco;
        public int QuantidadeEstoque;

        public void Receberdados()
        {
            Console.WriteLine("Digite o código do produto:");
            CodigoProduto = Console.ReadLine();
            Console.WriteLine("Digite o nome do produto:");
            NomeProduto = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto:");
            Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade em estoque:");
            QuantidadeEstoque = int.Parse(Console.ReadLine());
        }
        public void RemoverEstoque()
        {
            Console.Write("Quantidade a remover: ");
            int quantidade = int.Parse(Console.ReadLine());

            if (quantidade <= QuantidadeEstoque)
            {
                QuantidadeEstoque -= quantidade;
                Console.WriteLine("Estoque removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Quantidade insuficiente em estoque!");
            }
        }
        public void Adicionarestoque()
        {
            Console.WriteLine("Digite a quantidade a ser adicionada ao estoque: ");
            int quantidadeAdicionar = int.Parse(Console.ReadLine());
            QuantidadeEstoque += quantidadeAdicionar;
            Console.WriteLine("Quantidade adicionada. Estoque atualizado: " + QuantidadeEstoque);
        }
        public void Mostrarprodutos()
        {
            Console.WriteLine("Código do Produto: " + CodigoProduto);
            Console.WriteLine("Nome do Produto: " + NomeProduto);
            Console.WriteLine("Preço: " + Preco);
            Console.WriteLine("Quantidade em Estoque: " + QuantidadeEstoque);
        }
    }
}
