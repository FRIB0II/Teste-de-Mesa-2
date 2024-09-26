namespace TesteMesa2
{
    public class Exercício4
    {
        public static void Atividade4()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Exercício 4. \n");

            double valorPresente, taxaJuros, taxaJurosFormat;
            double rendimento = 0.0;
            int periodoAnos;

            Console.Write("Informe o capital inicial: ");
            valorPresente = double.Parse(Console.ReadLine());

            Console.Write("Informe a taxa de juros: ");
            taxaJuros = double.Parse(Console.ReadLine());
            taxaJurosFormat = taxaJuros;
            taxaJuros = (taxaJuros / 100) + 1;

            Console.Write("Informe a quantidade de anos inteira (exem: 1 = 24): ");
            periodoAnos = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            for (int i = 1; i <= periodoAnos; i++)
            {
                rendimento = valorPresente * Math.Pow(taxaJuros, i);
            }

            Console.WriteLine($"O redimento total é de R${rendimento:F2}");
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
