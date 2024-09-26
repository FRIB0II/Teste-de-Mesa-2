using System.ComponentModel.DataAnnotations;

namespace TesteMesa2
{
    public class Exercício1
    {
        public static void Atividade1()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Exercício 1. \n");

            double valorPresente = 1000.00;
            double taxaJuros = 5.30;
            int periodoMes = 10;

            Console.WriteLine("Dados: ");
            Console.WriteLine($"Capital inicial: R${valorPresente}");
            Console.WriteLine($"Taxa de juros a.m.: {taxaJuros}%");
            Console.WriteLine($"Tempo de investimento: {periodoMes} meses \n");

            double rendimentoTotal = valorPresente * Math.Pow(((taxaJuros / 100) + 1), periodoMes);

            Console.WriteLine($"O rendimento total é: R${rendimentoTotal:F2}");
            
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
