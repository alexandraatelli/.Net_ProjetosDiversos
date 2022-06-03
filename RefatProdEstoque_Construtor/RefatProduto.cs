using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefatProdEstoque_Construtor.cs
{
    internal class RefatProduto // após instanciar no programa principal, o construtor vem logo após os atributos. Ele inicia valores nas variáveis.
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //O construtor tem o mesmo nome da classe. É uma operação que tem mesmo nome da Classe. Incia com public. Podemos informar se tem algum parâmetro de entrada. Aqui no exemplo temos (parametros, inicia com letra minuscula)
        // Isso significa que quando instanciar já é obrigado a informar os atributos acima no Construtor.
        // Com os dados informados no construtor, atribui-se a cada atributo da classe.
        public RefatProduto (string nome, double preco, int quantidade)
        {
            Nome = nome; // Nome maiúsculo do atributo do objeto, vai receber nome em minúsculo, que é o dado que chegou de entrada no construtor.
            Preco = preco;
            Quantidade = quantidade;
        }

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