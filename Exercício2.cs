namespace TesteMesa2
{
    public class Exercício2
    {
        public static void Atividade2()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Exercício 2 \n");

            double valorPresente = 3800.00;
            double taxaJurosPerc = 1.25;
            double rendimento;
            double rendimentoLiquido;
            int periodoMes = 6;
            string rendFormatado;
            string rendLiqFormatado;

            Console.WriteLine("Dados: ");
            Console.WriteLine($"Capital inicial: R${valorPresente}");
            Console.WriteLine($"Taxa de juros a.m.: {taxaJurosPerc}%");
            Console.WriteLine($"Tempo de investimento: {periodoMes} meses.\n");

            Console.WriteLine("|Loop a.m\t|Taxa Juros\t|Rendimento\t|Rend. Liquido\t|Renda Acumulada|");

            for (int i = 1; i <= periodoMes; i++)
            {
                rendimento = valorPresente * (Math.Pow(((taxaJurosPerc / 100) + 1), i));
                rendimentoLiquido = rendimento - valorPresente;

                Console.WriteLine("");
                Console.Write($"|{i}\t\t|");
                Console.Write($"{taxaJurosPerc}%\t\t|");
                Console.Write($"R${rendimento:F2}\t|");
                Console.Write($"R${rendimentoLiquido:F2}\t|");
                Console.Write($"R${rendimento:F2}\t|");
            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
