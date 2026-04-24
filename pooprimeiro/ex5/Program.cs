namespace ex_5_classe_hospedes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hospede hospede = new hospede();
            hospede.Receberdados();
            hospede.MostrarDados();
            Console.WriteLine("Digite o novo telefone do hóspede:");
            String resposta = Console.ReadLine();
            if (resposta == "S" || resposta == "s")
            {
                
                Console.Write("Novo telefone: ");
                string novoTel = Console.ReadLine();
                hospede.AtualizarTelefone(novoTel);
                hospede.MostrarDados();

            }
            reserva reserva = new reserva();
            reserva.ReceberDadosReserva();
            reserva.CalcularTotal();

            Console.Write("\nDeseja aplicar desconto? (s/n): ");
            string respostaDesconto = Console.ReadLine();
            if (respostaDesconto == "s" || respostaDesconto == "S")
            {
                Console.Write("Percentual de desconto: ");
                double percentual = double.Parse(Console.ReadLine());
                reserva.AplicarDesconto(percentual);
            }

        }
    }
}
