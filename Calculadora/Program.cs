// Calculadora

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); // Limpa tela.
            Console.Write("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());//converter para não retornar uma string 
                                                           // armazenou o resultado digitado dentro
                                                           // da variável valor1.
            Console.Write("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 + valor2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            //Console.WriteLine("O resultado da soma é: " + resultado);
            //Console.WriteLine("O resultado da soma é " + (valor1 + valor2));
            //Console.WriteLine("O resultado da soma é {valor1 + valor2}");
        }
        // Devido várias operações (soma, multiplicação, divisão) não vamos deixar tudo dentro do método Main.
        static void soma()
        {

        }
    }
}
