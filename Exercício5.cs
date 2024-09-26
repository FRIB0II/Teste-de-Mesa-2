using System;

namespace TesteMesa2
{
    public class Exercício5
    {
        public static void Atividade5()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Exercício 5. \n");

            double valorPresente = 2000.00;
            double taxaJuros = 2.00;
            double taxaJurosFormat = (taxaJuros / 100) + 1;
            double rendimento, rendimentoLiquido, saldoPosResgate;
            double resgateRendimento = 0.0;
            int periodoMes = 6;
            char escolha;

            Console.WriteLine("|Loop a.m\t|Taxa Juros\t|Rendimento\t\t|Rend. Liquido\t\t|Renda Acumulada\t|Resgate\t|Saldo\t|");

            for (int i = 1; i <= periodoMes; i++)
            {
                rendimento = valorPresente * (Math.Pow(taxaJuros, i));
                rendimentoLiquido = rendimento - valorPresente;

                if (i == 5)
                {
                    Console.WriteLine("\n");
                    Console.Write("Deseja sacar seu dinheiro?: ");
                    escolha = char.Parse(Console.ReadLine());

                    if (escolha == 's' || escolha == 'S')
                    {
                        Console.Write("Digite a quantidade a ser sacada: ");
                        resgateRendimento = double.Parse(Console.ReadLine());
                        rendimento = rendimento - resgateRendimento;
                        saldoPosResgate = rendimento;
                        rendimento = valorPresente * (Math.Pow(taxaJuros, i));
                        rendimentoLiquido = rendimento - valorPresente;

                        Console.WriteLine("");
                        Console.Write($"|{i}\t\t|");
                        Console.Write($"{taxaJurosFormat}%\t\t|");
                        Console.Write($"R${rendimento:F2}\t\t|");
                        Console.Write($"R${rendimentoLiquido:F2}\t\t|");
                        Console.Write($"R${rendimento:F2}\t\t|");
                        Console.Write($"R${resgateRendimento}\t\t|");
                        Console.Write($"R${saldoPosResgate}\t\t|");

                        resgateRendimento = 0.0;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.Write($"|{i}\t\t|");
                        Console.Write($"{taxaJurosFormat}%\t\t|");
                        Console.Write($"R${rendimento:F2}\t\t|");
                        Console.Write($"R${rendimentoLiquido:F2}\t\t|");
                        Console.Write($"R${rendimento:F2}\t\t|");
                        Console.Write($"{resgateRendimento}\t|\t");
                        Console.Write($"{rendimento}\t|\t");
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.Write($"|{i}\t\t|");
                    Console.Write($"{taxaJurosFormat}%\t\t|");
                    Console.Write($"R${rendimento:F2}\t\t|");
                    Console.Write($"R${rendimentoLiquido:F2}\t\t|");
                    Console.Write($"R${rendimento:F2}\t\t|");
                    Console.Write($"{resgateRendimento}\t|\t");
                    Console.Write($"{rendimento}\t|\t");
                } 
            }
            Console.WriteLine("");
        }
    }
}
