/* Fazer um programa que lê os dados de um produto e estoque (nome, preço e quantidade). Em seguida:
 *  Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no estoque);
 *  Realizar uma entrafa no estoque e mostrar novamente os dados do produto;
 *  Realizar uma saída no estoque e mostrar novamente os dados do produto.
   
 Criar uma classe conforme o projeto UML:
 
 **********************************************
 ***                 Produto                 **
 **********************************************
 **            - Nome: string                **
 **            - Preco: double               **
 **            - Quantidade: int             **
 **********************************************
 **  + ValorTotalEmEstoque(): double         **
 **  + AdicionarProdutos(quantity:int):void  **
 **  + RemoverProdutos(quantity:int):void    **
 **********************************************
 
*/

namespace Produto_Estoque_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(); // criamos uma variável composta com 3 atributos: nome, preço e quantidade.
            // p é uma variável - object.

            Console.Write("Digite o nome do produto: ");
            p.Nome = Console.ReadLine();
            Console.Write("Digite o preço do produto: ");
            p.Preco = double.Parse(Console.ReadLine()); ;
            Console.Write("Digite quantidade do produto em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Dados do produto: {p}"); 
            // variável p. Quando colocar o object p dentro do Console.WriteLine, ele implicitamente vai chamar o método ToString e vai fazer a conversão, então aqui após a variável p não tem necessidade de colocar novamente o método ToString.


            Console.Write("\nDigite o número de produtos a serem adicionados no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte); 
            // Operação que é capaz de receber o valor de entrada e adicioná-lo na quantidade que já está armazenada na variável Quantidade do Produto p.
            Console.WriteLine($"Dados do produto: {p}");
            
            Console.Write("\nDigite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());// ela já foi declarada acima. Então não declara mais.
            p.RemoverProdutos(qte); 
            // Operação que é capaz de remover a quantidade deseja do Produto p, que está armazenada na variável Quantidade do Produto p.
            Console.WriteLine($"Dados do produto: {p}");



        }
    }
}





