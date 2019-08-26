using System.Globalization;

namespace _0051_ConstrutoresProdutoEstoque {
    class Produto {
        /*ATRIBUTOS DA CLASSE PRODUTO*/
        public string Nome;
        public double Preco;
        public int Quantidade;
        /*Construindo CONSTRUTORES: 
         * Regra01: Definido depois dos atributos.
           Regra02: Recebe o mesmo nome da Classe.
           Regra03: Definir se recebe ou não parametros.*/

        /*EXEMPLO DE CONSTRUTOR*/
        public Produto() { }

        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
            Quantidade = 50;
        }
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
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " UND, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
