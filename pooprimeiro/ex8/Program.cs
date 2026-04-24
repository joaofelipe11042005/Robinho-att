namespace exercicio_8_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reserva r1 = new Reserva("Carlos", 12);
            Reserva r2 = new Reserva("", -8, 0, -300);

            r1.ExibirReservas();
            r2.ExibirReservas();

            Console.WriteLine("Total r1: " + r1.CalcularTotal());
            Console.WriteLine("Total r2: " + r2.CalcularTotal());

            r1.AdicionarDiarias(2);
            r1.ExibirReservas();

            r2.CancelarReserva();
            r2.ExibirReservas();

            r2.ReativarReserva();
            r2.ExibirReservas();
        }
    }
}
