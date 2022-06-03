/* Retângulo - Fazer um programa para ler os valores da largura e altura de um retângulo. 
 * Em seguida mostrar na tela o valor de sua área, perímetro e diagonal. 
 * Usar uma classe como mostrado no projeto UML abaixo:
  
 ****************************
 **        Retangulo       **
 ****************************
 **    - Largura: double   **
 **    - Altura: double    **
 ****************************
 ** + Area() : double      **
 ** + Perimetro() : double **
 ** + Diagnal() : double   **
 ****************************
 */
using System.Globalization;

namespace Retangulo_cs
{
    class Program
    {
        static void Main(String[] args)
        {
            Retangulo ret = new Retangulo(); // Criou a variável ret e já instanciamos.

            Console.Write("Digite a Largura do Retangulo:");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a Atura do Retangulo:");
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Área do Retangulo: {ret.Area().ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perimêtro do Retângulo: {ret.Perimetro().ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal do Retângulo: {ret.Diagonal().ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}


