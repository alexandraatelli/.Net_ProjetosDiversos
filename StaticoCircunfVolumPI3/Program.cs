// Versão 3 do Programa: CLASSE CALCULADORA COM MÉTODO ESTÁTICO.

using System.Globalization;

namespace StaticoCircunfVolumPI3_cs
{
    class Program3
    {
        static void Main(string[] args)
        {
            // Calculadora calc = new Calculadora(); Sai esse objeto calc.
                                          
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // As chamadas das operações abaixo será diretamente a partir do nome da classe Calculadora
            // e não mais de um objeto instanciado dessa classe.

            double circ = Calculadora.Circunferencia(raio); 
            double volume = Calculadora.Volume(raio);


            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}