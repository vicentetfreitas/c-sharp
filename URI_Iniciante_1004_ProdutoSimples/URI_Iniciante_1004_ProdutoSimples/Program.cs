//Leia dois valores inteiros.A seguir, calcule o produto entre estes dois valores
//e atribua esta operação à variável PROD. A seguir mostre a variável PROD com mensagem correspondente.

//Entrada
//O arquivo de entrada contém 2 valores inteiros.

//Saída
//Imprima a variável PROD conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.
//Não esqueça de imprimir o fim de linha após o produto, caso contrário seu programa apresentará a mensagem: 
//“Presentation Error”.

//LINK:
//https://www.urionlinejudge.com.br/judge/pt/problems/view/1004

using System;

namespace URI_Iniciante_1004_ProdutoSimples {
    class Program {
        static void Main(string[] args) {

            int a, b, PROD;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            PROD = a * b;

            Console.WriteLine("PROD = "+ PROD);
        }
    }
}
