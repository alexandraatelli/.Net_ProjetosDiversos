using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto_Estoque_cs
{
    internal class Produto // nome de classe e atributo começa com letra (maiúscula).
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        // valor total em estoque:
        public double ValorTotalEmEstoque()
        {   // retorna como saída um valor preço * quantidade
            return Preco * Quantidade;
        }
        // É void(vazio) pois não irá retornar nada, só vai Quantidade e acrescentará produto no estoque.
        public void AdicionarProdutos(int quantidade) // Essa operação vai precisar receber um dado de entrada, que é a quantidade a ser adicionada no estoque. Quando vai colocar alguma variável como parâmetro de entrada de função, inicia-se com letra minúscula - convenção.)
        { 
            Quantidade = Quantidade + quantidade;
        }
        public void RemoverProdutos(int quantidade)//Vamos remover produtos do estoque
        {
            Quantidade = Quantidade - quantidade;
        }

        // Faremos uma sobreposição:
        public override string ToString()
        {
            return Nome
                + ", R$ "
                + Preco.ToString("F2")
                + ", "
                + Quantidade
                + " unidade, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2");
        }
    }
}

/* Toda classe em C# é uma subclasse de Object - Object é uma classe genérica - Triangulo, Produto é uma 
 * classe Object. Esse conceito de subclasse é entendindo melhor em Herança. Essa classe Object possui os 
 * seguintes métodos: 
 * Getype - retorna o tipo do objeto;
 * Equals - compara se o objeto é igual a outro;
 * GetHashCode - retorna um código hash do objeto;
 * ToString - converte o objeto para string;
 */
