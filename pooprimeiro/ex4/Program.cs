namespace ex_4_calculadora_de_salario
{
internal class Program
{
    static void Main(string[] args)
    {
            CalculadoraDeSalario calc = new CalculadoraDeSalario();

            calc.ReceberDados();

            Console.Write("Informe o percentual de aumento: ");
            double aumento = double.Parse(Console.ReadLine());
            calc.CalcularAumento(aumento);

            Console.Write("Informe o percentual de desconto: ");
            double desconto = double.Parse(Console.ReadLine());
            calc.CalcularDesconto(desconto);

            calc.MostrarSalario();
        }
    }
}
