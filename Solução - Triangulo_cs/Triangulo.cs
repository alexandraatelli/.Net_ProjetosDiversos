using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Classe é fundamento principal da orientação a objetos

namespace Area_Triangulo_com_OO.cs
{
    public class Triangulo // nome de classe com letra Maiúscula. A classe também é um tipo.
    {
        // atributo: definição da classe - declarados como public para ter acesso ao programa principal.
        public double A;
        public double B;
        public double C;

        // agora teremos 2 variáveis: O x, que vai apontar para um objeto composto (A, B, C), assim como o y.
        // Deve-se instanciar as variáveis: alocação dinâmica de memória com o comando new (na área Heap)
    }
}
