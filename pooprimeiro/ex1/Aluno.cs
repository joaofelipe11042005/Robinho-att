using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_robson_17._03
{
    internal class Aluno
    {
        public string RA;
        public string Nome;
        public double NotaProva;
        public double NotaTrabalho;
        public double NotaFinal;

      
        public void ReceberDados()
        {
            Console.Write("Digite o RA: ");
            RA = Console.ReadLine();

            Console.Write("Digite o Nome: ");
            Nome = Console.ReadLine();

            Console.Write("Digite a Nota da Prova: ");
            NotaProva = double.Parse(Console.ReadLine());

            Console.Write("Digite a Nota do Trabalho: ");
            NotaTrabalho = double.Parse(Console.ReadLine());
        }

       
        public void CalcularMedia()
        {
            NotaFinal = (NotaProva + NotaTrabalho) / 2;
        }
        public bool CalcularNotaFinal()
        {
            if (NotaFinal >= 6.0)
            {
                Console.WriteLine("Aluno aprovado diretamente!");
                return true;
            }
            else
            {
                double notaNecessaria = (6.0 * 2) - NotaFinal;

                Console.WriteLine("Aluno precisa fazer prova final.");
                Console.WriteLine("Nota necessária na prova final: " + notaNecessaria);

                return false;
            }
        }

     
        public void ImprimirNotaFinal()
        {
            Console.WriteLine("Nota Final: " + NotaFinal);
        }
    }
}
