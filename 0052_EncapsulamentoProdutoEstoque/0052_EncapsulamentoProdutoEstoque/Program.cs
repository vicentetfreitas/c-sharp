using System;
using System.Globalization;
namespace _0052_EncapsulamentoProdutoEstoque {
    class Program {
        static void Main(string[] args) {
            //MANUAL
            Produto p = new Produto("TV", 500, 10);

            //Encapsulamento
            //p.SetNome("TV 4K");
            //Console.WriteLine(p.GetPreco());

            //Properties
            p.Nome = "TV 4k";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}
