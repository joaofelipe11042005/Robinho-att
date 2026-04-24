

namespace exe_robson_17._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno Aluno = new Aluno();
            Aluno.ReceberDados();
            Aluno.CalcularMedia();
            Aluno.ImprimirNotaFinal();
            Aluno.CalcularNotaFinal();

            Console.ReadKey();
        }
    }
}
