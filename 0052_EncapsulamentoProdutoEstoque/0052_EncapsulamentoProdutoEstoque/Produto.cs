using System.Globalization;

namespace _0052_EncapsulamentoProdutoEstoque {
    class Produto {

        /*ATRIBUTOS DA CLASSE PRODUTO*/
        private string _nome;
        private double _preco;
        private int _quantidade;
        /*Construindo CONSTRUTORES: 
         * Regra01: Definido depois dos atributos.
           Regra02: Recebe o mesmo nome da Classe.
           Regra03: Definir se recebe ou não parametros.*/

        /*EXEMPLO DE CONSTRUTOR*/
        public Produto() { }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public Produto(string nome, double preco) {
            _nome = nome;
            _preco = preco;
            _quantidade = 50;
        }
        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }
        //void=vazio: S/retorno
        //int quantidade: dados de entrada
        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }

        public string GetNome() {
            return _nome;
        }
        public double GetPreco() {
            return _preco;
        }
        public int GetQuantidade() {
            return _quantidade;
        }
        public void SetNome(string nome) {

            if (nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }
        public override string ToString() {
            return _nome
                + ", $"
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " UND, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
