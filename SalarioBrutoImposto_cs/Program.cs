/* Nome, Salário Bruto e Impostos: Fazer um programa para ler os dados de um funcionário 
 * (nome, salário bruto e imposto). Em seguida, mostrar os dados do funcionário (nome e salário líquido).
 * Após, aumentar o salário do funcionário com base em uma porcentagem dada (somente o salário bruto
 * é afetado pela porcentagem) e mostrar novamente os dados do funcionário. 
 * NOTA: Exerício propôs o desconto do Imposto em reais e não em porcentagem sobre o salário bruto, ex: 1000,00 reais.
 
 * Classe projetada UML:
 
****************************************************
**                 Funcionario                    **
****************************************************
**  - Nome : string                               **
**  - SalarioBruto : double                       **
**  - Imposto : double                            **
****************************************************
** + SalarioLiquido() : double                    **
** + AumentarSalario(porcentagem : double) : void **
****************************************************

*/
using System.Globalization;

namespace SalarioBrutoImposto_cs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + func);

            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcent);

            Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + func);
            Console.WriteLine($"Dados atualizados: {func}");
        }
    }
}

