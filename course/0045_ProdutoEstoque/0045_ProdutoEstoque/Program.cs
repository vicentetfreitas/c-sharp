using System;
using System.Globalization;
namespace _0045_ProdutoEstoque {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write( "Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: R$ ");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Write( $"Dados do Produto: "+p);
            Console.WriteLine();
            Console.WriteLine("==========================================================");
            Console.Write("Digite o número de produtos a ser adicionado: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);
            Console.WriteLine();
            Console.WriteLine("==========================================================");
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);
        }
    }
}
