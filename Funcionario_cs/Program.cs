// Fazer um programa que lê o nome e salário de dois funcionários e após mostrar a média dos salários.

namespace Funcionario_cs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario primeiroFuncionario, segundoFuncionario;
            primeiroFuncionario = new Funcionario();
            segundoFuncionario = new Funcionario();

            Console.Write("Digite o nome do primeiro funcionário: ");
            primeiroFuncionario.nome = Console.ReadLine();
            Console.Write("Digite o salario: ");
            primeiroFuncionario.salario = float.Parse(Console.ReadLine());

            Console.Write("\nDigite o nome do segundo funcionário: ");
            segundoFuncionario.nome = Console.ReadLine();
            Console.Write("Digite o salario: ");
            segundoFuncionario.salario = float.Parse(Console.ReadLine());

            float mediaSalario = (primeiroFuncionario.salario + segundoFuncionario.salario) / 2;

            Console.WriteLine($"\nA média dos salários dos funcionários é de: {mediaSalario:C} reais!");
        }
    }
}
