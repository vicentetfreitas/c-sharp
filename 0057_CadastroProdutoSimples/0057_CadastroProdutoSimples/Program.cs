using System;
using System.Globalization;
namespace _0057_CadastroProdutoSimples {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Cadastro de Produtos.");
            Console.WriteLine();
            Console.Write("Quantidade de produto a ser cadastrado: ");
            int quant = int.Parse(Console.ReadLine());

            //nome do produto
            string[] produto;
            produto = new string[quant];
            //valor do protudo
            double[] valor;
            valor = new double[quant];
            //quantidade do estoque
            int[] estoque;
            estoque = new int[quant];
            //Valor Estoque
            double[] valEstoque;
            valEstoque = new double[quant];

            Console.WriteLine();
            for (int i = 0; i < quant; i++) {
                Console.Write($"Digite o nome do produto {i} : ");
                produto[i] = Console.ReadLine();
                Console.Write($"Digite o valor do produto {i}: R$");
                valor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Digite estoque: ");
                estoque[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < quant; i++) {
                valEstoque[i] = estoque[i] * valor[i];
                Console.WriteLine("Dados do produto: "
                + "Produto: " + produto[i]
                + ", Valor: R$ " + valor[i]
                + ", Estoque: " + estoque[i]
                + ", VALOR TOTAL: R$ " + valEstoque[i]);
            }

        }
    }
}
