using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticoCircunfVolumPI3_cs
{
    class Calculadora
    {   // Atributo:
        public static double Pi = 3.14; 

        // Ela tem 2 métodos: Circunsferencia e Volume:
        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;     // retorna o valor da circunferência.            
        }
        public static double Volume(double r) // Função de calcular o Volume de um raio r.
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0); // retorna o valor do volume.
        }
    }
}
// Precisamos adicionar o static após o public para permitir que estes membros possam
// serem chamados sem necessitar de instanciar objetos. Lá no Programa principal tiramos o objeto calc.