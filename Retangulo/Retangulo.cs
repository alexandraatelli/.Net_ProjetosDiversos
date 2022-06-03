using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo_cs
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area() // base * altura
        {
            return Largura * Altura;
        }
        public double Perimetro() // soma dos 4 lados 
        {
            return 2 * (Largura + Altura); // Abaixo tá melhor definido a fórmula para aplicação no C#
        } 
        public double Diagonal() // 
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}
