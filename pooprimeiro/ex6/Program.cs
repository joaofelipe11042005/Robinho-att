namespace exercicio6_classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Nome Cliente: ");
          string nome = Console.ReadLine();
          Console.WriteLine("CPF: ");
          string cpf = Console.ReadLine();
          Console.WriteLine("Cidade: ");
          string cidade = Console.ReadLine();

          Console.WriteLine("Nome vendedor: ");
          string nomeVendedor = Console.ReadLine();
          Console.WriteLine("Percentual de comissão: ");
          double percentualComissao = double.Parse(Console.ReadLine());

          Console.WriteLine("\n=== DADOS DO PRODUTO ===");
          Console.Write("Descrição: ");
          string descricao = Console.ReadLine();
          Console.Write("Preço unitário: ");
          double preco = double.Parse(Console.ReadLine());
          Console.Write("Quantidade: ");
          int quantidade = int.Parse(Console.ReadLine());

            
          Console.WriteLine("\n=== DADOS DO PAGAMENTO ===");
          Console.Write("Forma de pagamento: ");
          string forma = Console.ReadLine();
          Console.Write("Parcelas: ");
          int parcelas = int.Parse(Console.ReadLine());

          Console.WriteLine("\n=== DADOS DA ENTREGA ===");
          Console.Write("Endereço: ");
          string endereco = Console.ReadLine();
          Console.Write("Distância (km): ");
          double distancia = double.Parse(Console.ReadLine());
          Console.Write("Tipo (normal/expressa): ");
          string tipo = Console.ReadLine();


          Console.WriteLine("\n=== NÚMERO DO PEDIDO ===");
          Console.Write("Número do pedido: ");
          int numero = int.Parse(Console.ReadLine());


           Cliente cliente = new Cliente(nome, cpf, cidade);
           Vendedor vendedor = new Vendedor(nomeVendedor, percentualComissao);
           Produto produto = new Produto(descricao, preco, quantidade);
           Pagamento pagamento = new Pagamento(forma, parcelas);
           Entrega entrega = new Entrega(endereco, distancia, tipo);
           Pedido pedido = new Pedido(numero, cliente, vendedor, produto, pagamento, entrega);

           pedido.ExibirResumo();

        }
    }
}