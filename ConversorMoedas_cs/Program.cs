//Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser
// comprado por uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos
// dólares, considerando ainda que a pessoa terá que pagar 6% de IOF sobre o valor
// em dólar. Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos.

using System.Globalization;

namespace ConversorMoedas_cs
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a cotação do dolar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a quantia a ser comprada: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoedas.ConversaoDolarParaReal(quantia, cotacao);

            Console.WriteLine($"O valor a ser pago em reais é de: {result.ToString("F2", CultureInfo.InvariantCulture)} reais!");

        }
    }
}