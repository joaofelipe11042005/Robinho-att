namespace exercicio6_classe
{
    internal class Pedido
    {
        private Cliente cliente;
        private Vendedor vendedor;
        private Produto produto;
        private Pagamento pagamento;
        private Entrega entrega;

        public int Numero { get; }

        public Cliente Cliente
        {
            get { return cliente; }
            set { if (value != null) cliente = value; }
        }

        public Vendedor Vendedor
        {
            get { return vendedor; }
            set { if (value != null) vendedor = value; }
        }

        public Produto Produto
        {
            get { return produto; }
            set { if (value != null) produto = value; }
        }

        public Pagamento Pagamento
        {
            get { return pagamento; }
            set { if (value != null) pagamento = value; }
        }

        public Entrega Entrega
        {
            get { return entrega; }
            set { if (value != null) entrega = value; }
        }

        public Pedido(int numero, Cliente cliente, Vendedor vendedor,
                      Produto produto, Pagamento pagamento, Entrega entrega)
        {
            Numero = numero;
            Cliente = cliente;
            Vendedor = vendedor;
            Produto = produto;
            Pagamento = pagamento;
            Entrega = entrega;
        }

        public double CalcularValorFinal()
        {
            double subtotal = Produto.CalcularSubtotal();
            double taxa = Entrega.CalcularTaxaEntrega();
            double acrescimo = Pagamento.CalcularAcrescimo(subtotal);
            return subtotal + taxa + acrescimo;
        }

        public double CalcularComissaoVendedor()
        {
            return Vendedor.CalcularComissao(CalcularValorFinal());
        }

        public void ExibirResumo()
        {
            Console.WriteLine($"\n===== PEDIDO Nº {Numero} =====");

            Console.WriteLine("\n-- CLIENTE --");
            Cliente.ExibirDados();
            Console.WriteLine($"Apresentação: {Cliente.RetornarApresentacao()}");

            Console.WriteLine("\n-- VENDEDOR --");
            Vendedor.ExibirDados();

            Console.WriteLine("\n-- PRODUTO --");
            Produto.ExibirDados();
            Console.WriteLine($"Subtotal: R$ {Produto.CalcularSubtotal():F2}");

            Console.WriteLine("\n-- PAGAMENTO --");
            Pagamento.ExibirDados();
            Console.WriteLine($"Válido: {(Pagamento.ValidarPagamento() ? "Sim" : "Não")}");
            Console.WriteLine($"Acréscimo: R$ {Pagamento.CalcularAcrescimo(Produto.CalcularSubtotal()):F2}");

            Console.WriteLine("\n-- ENTREGA --");
            Entrega.ExibirDados();
            Console.WriteLine($"Taxa: R$ {Entrega.CalcularTaxaEntrega():F2}");

            Console.WriteLine("\n==============================");
            Console.WriteLine($"VALOR FINAL: R$ {CalcularValorFinal():F2}");
            Console.WriteLine($"COMISSÃO:    R$ {CalcularComissaoVendedor():F2}");
            Console.WriteLine("==============================");
        }
    }
}