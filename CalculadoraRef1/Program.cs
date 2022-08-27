// Refatorando Calculadora

using System;

namespace Calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soma();
            //Subtracao();
            //Divisao();
            //Multiplicacao();
            Menu();

        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Olá! Escolha uma das opcões abaixo:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());
        }

        static void Soma()
        {
            Console.Clear(); // Limpa tela.
            Console.Write("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 + valor2;
            Console.WriteLine($"\nO resultado da soma é: {resultado}");
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = (float)valor1 - valor2;
            Console.WriteLine($"\nO resultado da subtração é: {resultado}");
        }
        static void Divisao()
        {
            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = (float)valor1 / valor2;
            Console.WriteLine($"\n O resultado da divisão é: {resultado}");
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = (float)valor1 * valor2;
            Console.WriteLine($"\n O resultado da multiplicação é: {resultado}");
        }

    }
}
