namespace exercicio7_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme f1 = new Filme("Interstellar", "Ficção Científica", 169, 13);
            Filme f2 = new Filme("Toy Story", "Animação", 81, 0);
        
            f1.ExibirResumo();
            

            Console.WriteLine(f1.EhpermitidoParaIdade(10));
            Console.WriteLine(f1.EhpermitidoParaIdade(15));
            f1.ExibirInformacoes();
            f1.ExibirResumo();
            Console.WriteLine();
            f2.ExibirInformacoes();
            
            f2.AlterarDuracao(120);
            f2.ExibirResumo();
            try
            {
                Filme f3 = new Filme("", "", -30, -5);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }

        }
    }
}
