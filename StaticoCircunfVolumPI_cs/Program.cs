/* Fazer um programa para ler um valor númerico qualquer, e daí mostrar quanto seria o valor de uma circunferência e do volume de uma esfera para um raio daquele valor. Informar também o valor de PI com suas casas decimais

* Versão 1 do Programa: MÉTODO NA PRÓPRIA CLASSE DO PROGRAMA.

Nota: Dentro de um método estático você não pode chamar membros de instância da mesma classe.*/

using System.Globalization;

namespace StaticoCircunfVolumePI_cs
{
    class Program1
    {
        static double Pi = 3.14; // Tem que ser estático porque está usando o Pi dentro de uma operação estática.
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        
        // Função para calcular essa circunferência: nela não precisa colocar a palavra public, pois ela será usada dentro da própria classe. Mas conterá a palavra static para indicar que ela é uma função estática, poruqe ela vai ser chamada dentro da função Main que é uma função estática.

        static double Circunferencia(double r) // esse raio aqui não é variavel raio, aqui é só um parâmetro
        {                                       // que chegou aqui para minha função. Pode ate colocar outro
            return 2.0 * Pi * r;                // nome aqui, exemplo: variável r que será a variável que a
        }                                       // função recebeu como entrada.
                                              
        static double Volume(double r) // Função de calcular o Volume de um raio r
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}

