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
            
            double taxaJuros = 0.0530;
            
            int periodoMes = 10;

            double rendimentoTotal = valorPresente * Math.Pow((1 + taxaJuros), periodoMes);

            Console.WriteLine($"O rendimento total é: R${rendimentoTotal:F2}");

            Console.WriteLine("");
        }
    }
}
