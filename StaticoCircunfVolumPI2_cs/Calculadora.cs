using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticoCircunfVolumPI2_cs
{
    class Calculadora
    {   // Atributo:
        public double Pi = 3.14; // sai static e entra public para que esses membros possam serem acessados em outro lugar, no caso, no programa principal.
        
        // Ela tem 2 métodos: Circunsferencia e Volume:
        public double Circunferencia(double r) 
        {                                       
            return 2.0 * Pi * r;     // retorna o valor da circunferência.            
        }
        public double Volume(double r) // Função de calcular o Volume de um raio r.
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3); // retorna o valor do volume.
        }
    }
}
