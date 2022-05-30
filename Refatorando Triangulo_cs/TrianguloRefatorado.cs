using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refatorando_Triangulo_cs
{
    internal class TrianguloRefatorado
    {
        public double A;
        public double B;
        public double C;

        public double Area() // criamos aqui um método da classe Triangulo, ~que é uma função dentro da propria classe.// se não retorna-se nada, colocariamos void.
        {
            double p = (A + B + C) / 2.0; // A B C do triângulo em questão - acessando os póoprios atributos do triângulo.
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C) ); // faz parte do System.
            return raiz; 
                     
            // Ela vai retornar esse valor raiz.
            //return double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - c) ); Se preferir pode colocar a função retorn diretamente na expressão. Veja exemplo: 
        }
           // método public (acessado em outro arquivo). Esse método de calcular a área será uma função que calcula a área e retorna o valor, então é valor numérico o resultado e o tipo desse método é double. O nome da função é Area (maiuscula) que repesenta o que ela é. Entre os parêntes, que geralmente é colocado os parâmentos de entrada da função, PORÉM, essa função Area já está dentro da class Triangulo, precisamos somente dos dados A, B e C, que também já são da classe Triangulo, essa função Area não precisará de mais nenhum dado adicional.
    }
}
/*Projeto da Classe antes de programar em UML:

 ****************************
 **Refatorando_Triangulo_cs**   Nome da classe
 ****************************
 ** + A : double           **
 ** + B : double           **   Atributos da classe
 ** + C : double           **
 ****************************
 ** + Area() : double      **   Métodos da classe
 ****************************

 */ 