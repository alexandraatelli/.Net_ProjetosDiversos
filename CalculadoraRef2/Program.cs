// Refatorando CalculadoraRef1.cs

using System;

namespace Calculadora2.cs
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
            Console.WriteLine("5 - Sair");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine());

            // Qual método vamos chamar para usuário quando escolher a opção.

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;// Sair do sistema aqui no console, do ambiente.
                default: Menu(); break;
            }
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
            Console.ReadKey();
            Menu();
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
            Console.ReadKey();
            Menu();
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
            Console.ReadKey();
            Menu();
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
            Console.ReadKey();
            Menu();
        }
    }
}
