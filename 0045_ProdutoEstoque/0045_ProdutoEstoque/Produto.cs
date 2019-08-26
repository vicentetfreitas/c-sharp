using System;
using System.Globalization;

namespace _0045_ProdutoEstoque {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        //void=vazio: S/retorno
        //int quantidade: dados de entrada
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return Nome 
                + ", $" 
                + Preco.ToString("F2",CultureInfo.InvariantCulture )
                + ", "
                + Quantidade 
                + " UND, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
