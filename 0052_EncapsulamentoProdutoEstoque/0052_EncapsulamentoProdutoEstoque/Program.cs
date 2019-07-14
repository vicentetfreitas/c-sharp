using System;
using System.Globalization;
namespace _0052_EncapsulamentoProdutoEstoque {
    class Program {
        static void Main(string[] args) {
            //MANUAL
            Produto p = new Produto("TV", 500, 10);

            p.SetNome("TV 4K");

            Console.WriteLine(p.GetNome());
        }
    }
}
