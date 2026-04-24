namespace ex_3_produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            produto produto = new produto();
            produto.Receberdados();
            produto.Adicionarestoque();
            produto.RemoverEstoque();
            produto.Mostrarprodutos();
        }
    }
}
