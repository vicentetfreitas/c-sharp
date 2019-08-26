//Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, 
//o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. 
//Após, calcule e mostre o valor a ser pago.

//Entrada
//O arquivo de entrada contém duas linhas de dados.
//Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.

//Saída
//A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, 
//lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". 
//    O valor deverá ser apresentado com 2 casas após o ponto.

using System;
using System.Globalization;

namespace URI_Iniciante_1010_CalculoSimples {
    class Program {
        static void Main(string[] args) {

            string[] peca1 = Console.ReadLine().Split(' ');
            int cd = int.Parse(peca1[0]);
            int quantPeca = int.Parse(peca1[1]);
            double valor = double.Parse(peca1[2],CultureInfo.InvariantCulture);

            string[] peca2 = Console.ReadLine().Split(' ');
            int cd2 = int.Parse(peca2[0]);
            int quantPeca2 = int.Parse(peca2[1]);
            double valor2 = double.Parse(peca2[2],CultureInfo.InvariantCulture);

            double valorPagar = (quantPeca * valor )+(quantPeca2 * valor2);

            Console.WriteLine("VALOR A PAGAR: R$ "+valorPagar.ToString("F2",CultureInfo.InvariantCulture));            



        }
    }
}
