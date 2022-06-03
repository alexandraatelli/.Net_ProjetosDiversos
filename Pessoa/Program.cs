// Programa que lê nome e idade de Pessoa e que mostre na tela a de mais idade.

using Pessoa.cs;

namespace Pessoa.cs // mesmo namespace da classe Pessoa.cs
{
    public class Program // criei a classe Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;// Criamos duas variáveis do tipo Pessoa e as instanciamos:

            // método construtor = são duas pessoas e vai receber os dois atributos de Pessoas: nome e idade
            pessoa1 = new Pessoa(); 
            pessoa2 = new Pessoa();

            Console.Write("Digite o nome da primeira Pessoa: ");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Digite a idade: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da segunda Pessoa: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Digite a idade: ");
            pessoa2.idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"{pessoa1.nome} tem {pessoa1.idade} anos.");
            Console.WriteLine($"{pessoa2.nome} tem {pessoa2.idade} anos.");

            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine($"{pessoa1.nome} é a pessoa de mais idade entre eles!");
            }
            else if (pessoa1.idade == pessoa2.idade)
            {
                Console.WriteLine($"{pessoa1.nome} e {pessoa2.nome} possuem a mesma idade!");
            }
            else
            {
                Console.WriteLine($"{pessoa2.nome} é a pessoa de mais idade entre eles!");
            }
        }
    }
}


    

