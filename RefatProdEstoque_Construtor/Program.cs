/* Refatorando o exercício Produto Estoque_cs com uso de Construtores.
 (* Fazer um programa que lê os dados de um produto e estoque (nome, preço e quantidade). Em seguida:
 *  Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no estoque);
 *  Realizar uma entrafa no estoque e mostrar novamente os dados do produto;
 *  Realizar uma saída no estoque e mostrar novamente os dados do produto.)*/


namespace RefatProdEstoque_Construtor.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando o produto ele já inicia com nulo, zero...a depender do tipo
            // dos atributos. Com o construtor o programador é obrigado a informar valores
            // ao instanciar. Construtor vem logo após os atributos lá na classe RefatProdutos.
            // RefatProduto p = new RefatProduto("TV, 500.0, 10"); //Tem que informar os parâmetros aqui () se não informa erro, ele tá pedindo os argumentos. O construtor obriga entrar com os dados.


            // Aqui vou criar variáveis temporárias auxiliares, só para receber os dados, e somente
            // que vamos chamar o construtor para instaciar o objeto:
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine()); 
            Console.Write("Digite quantidade do produto em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            
            RefatProduto p = new RefatProduto(nome, preco, quantidade);
            // Recebe o nome, preço e quantidade que o usuario digitou, instancia o objeto já informando os dados para ele.
            Console.WriteLine($"Dados do produto: {p}");


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
          