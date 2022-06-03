/* Fazer um programa para ler um valor númerico qualquer, e daí mostrar quanto seria o valor 
 * de uma circunferência e do volume de uma esfera para um raio daquele valor. Informar também
 * o valor de PI com suas casas decimais

* Versão 2 do Programa: CLASSE CALCULADORA COM MEMBROS DE INSTÂNCIA.*/

using System.Globalization;

namespace StaticoCircunfVolumPI2_cs
{
    class Program2
    {
       
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();// instância porque a calculadora é uma classe e
                                                 // devemos instanciá-la para trabalhar com ela.
                                                 // As operações serão chamadas a partir da calculadora
                                                 // calc.
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double circ = calc.Circunferencia(raio); // operação circunferencia da classe calculadora
                                                     // será chamada aqui e o resultado será chama aqui
                                                     // e o resultado será armazenado na variavel circ.
            double volume = calc.Volume(raio);


            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        // Função para calcular essa circunferência: nela não precisa colocar a palavra public,
        // pois ela será usada dentro da própria classe. Mas conterá a palavra static para indicar
        // que ela é uma função estática, poruqe ela vai ser chamada dentro da função Main
        // que é uma função estática.
    }
}
/* 
 * Nota: Aqui no caso da calculadora, os valores dos cálculos não mudam para calculadoras
 * diferentes, ou seja, são cálculos estáticos. O valor de Pi também é estático.
*/
