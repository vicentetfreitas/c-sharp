using System.Globalization;

namespace _0052_EncapsulamentoProdutoEstoque {
    class Produto {

        /*ATRIBUTOS DA CLASSE PRODUTO*/
        private string _nome;
        //Auto-Properties
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        //private double _preco;
        //private int _quantidade;

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

        //Properties
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }
        //Encapsulamento
        //public string GetNome() {
        //    return _nome;
        //}
        //public double GetPreco() {
        //    return _preco;
        //}
        //public int GetQuantidade() {
        //    return _quantidade;
        //}
        //public void SetNome(string nome) {

        //    if (nome != null && nome.Length > 1) {
        //        _nome = nome;
        //    }
        //}
        public override string ToString() {
            return _nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " UND, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
