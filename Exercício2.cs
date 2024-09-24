using System.Globalization;

namespace TesteMesa2
{
    public class Exercício2
    {
        public static void Atividade2()
        {
            Console.Clear();
            Console.WriteLine("");

            double valorPresente = 3800.00;
            double taxaJurosPerc = 1.0125;
            double rendimento;
            double rendimentoLiquido;
            int periodoMes = 6;
            string rendFormatado;
            string rendLiqFormatado;


            Console.WriteLine("|Loop a.m\t|Taxa Juros\t|Rendimento\t|Rend. Liquido\t|Renda Acumulada|");

            for (int i = 1; i <= periodoMes; i++)
            {
                rendimento = valorPresente * (Math.Pow((taxaJurosPerc), i));
                rendimentoLiquido = rendimento - valorPresente;

                Console.WriteLine("");
                Console.Write($"|{i}\t\t|");
                Console.Write($"{taxaJurosPerc*100}%\t|");
                Console.Write($"R${rendimento:F2}\t|");
                Console.Write($"R${rendimentoLiquido:F2}\t|");
                Console.Write($"R${rendimento:F2}\t|");
            }
            Console.WriteLine("");
        }
    }
}
