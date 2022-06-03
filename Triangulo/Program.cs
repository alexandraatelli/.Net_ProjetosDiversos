/* 
Fazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas
válidas). Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos
possui a maior área.
A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é a
fórmula de Heron.

Entre com as medidas do triângulo X:    Entre com as medidas do triângulo Y:
3.00                                    7.50
4.00                                    4.50
5.00                                    4.02

Resultado tem que ser:
Área de X = 6.0000
Área de Y = 7.5638
Maior área: Y
*/

using System.Globalization;

namespace Area_Triangulo_com_OO.cs // Divisão lógica
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
            Triangulo x, y; // Criamos as variáveis x e y do tipo de classe Triangulo. O x e y são duas variáveis compostas dentro da Memória Heap, que tem que serem instanciadas.
            x = new Triangulo(); // Instanciamos com new
            y = new Triangulo(); // Instanciamos  "   "

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

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

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

/* Mesmo Programa sem a utilização de OO:
 

using System.Globalization;

namespace MyNamespace
{
    class Triangulo
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

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
}*/