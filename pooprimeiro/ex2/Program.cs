
namespace ex_2_conta_bancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            contabancaria conta = new contabancaria();

            conta.ReceberDados();
            conta.Depositar();
            conta.Sacar();
            conta.mostrarsaldo();
        }
    }
}
