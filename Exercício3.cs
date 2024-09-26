namespace TesteMesa2
{
    public class Exercício3
    {
        public static void Atividade3()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Exercício 3. \n");

            double valorPresente, taxaJurosPerc, taxaJurosFormat, rendimento, rendimentoLiquido;
            int periodoMes;

            Console.Write("Informe o capital inicial: ");
            valorPresente = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a taxa de juros: ");
            taxaJurosPerc = Convert.ToDouble(Console.ReadLine());
            taxaJurosFormat = taxaJurosPerc;
            taxaJurosPerc = (taxaJurosPerc / 100) + 1;


            Console.Write("Informe a quantidade de meses a ser calculado: ");
            periodoMes = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("|Loop a.m\t|Taxa Juros\t|Rendimento\t\t|Rend. Liquido\t\t|Renda Acumulada\t|");

            for (int i = 1; i <= periodoMes; i++)
            {
                rendimento = valorPresente * (Math.Pow(taxaJurosPerc, i));
                rendimentoLiquido = rendimento - valorPresente;

                Console.WriteLine("");
                Console.Write($"|{i}\t\t|");
                Console.Write($"{taxaJurosFormat}%\t\t|");
                Console.Write($"R${rendimento:F2}\t\t|");
                Console.Write($"R${rendimentoLiquido:F2}\t\t|");
                Console.Write($"R${rendimento:F2}\t\t|");
            }
            Console.WriteLine("");
        }
    }
}
