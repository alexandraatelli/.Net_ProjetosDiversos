// Refatorando o exercício da Classe Triângulo:

using System.Globalization;

namespace Refatorando_Triangulo_cs // Divisão lógica
{
    public class Program // classe Program
    {
        static void Main(string[] args) //O método Main é o ponto de entrada de um aplicativo C#.
                                        //(Bibliotecas e serviços não exigem um Main método como um
                                        //ponto de entrada.) Quando o aplicativo é iniciado, o Main
                                        //método é o primeiro método que é invocado.
                                        // O void é tipo de retorno do método. Este tipo de retorno
                                        // significa vazio/nada, o método não dá retorno nenhum.
                                        // Os métodos podem retornar qualquer tipo do seu projeto,
                                        // até mesmo os criados por você.
        {
            TrianguloRefatorado x, y; // Criamos as variáveis x e y do tipo de classe Triangulo.
                                      // O x e y são duas variáveis compostas dentro da Memória Heap,
                                      // que tem que serem instanciadas.
            x = new TrianguloRefatorado(); // Instanciamos com new
            y = new TrianguloRefatorado(); // Instanciamos  "   "

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            // Acesso o atributo do objeto x (A, B, C) e armazeno-os no objeto x (x.A - x.B - x.C), veja abaixo:
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // Acesso o atributo do objeto y (A, B, C) e armazeno-os no objeto y:
            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine($"A área do triângulo X é de: {areaX.ToString("f4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"A área do triângulo Y é de: {areaY.ToString("f4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área é X");
            }
            else
            {
                Console.WriteLine("Maior áreá é Y");
            }
        }
    }
}

