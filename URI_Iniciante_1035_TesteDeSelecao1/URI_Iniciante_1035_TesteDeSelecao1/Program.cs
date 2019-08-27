//Leia 4 valores inteiros A, B, C e D.A seguir, se B for maior do que C e se D for maior do que A,
//e a soma de C com D for maior que a soma de A e B e se C e D, ambos,    
//forem positivos e se a variável A for par escrever a mensagem "Valores aceitos", 
//senão escrever "Valores nao aceitos".

//Entrada
//Quatro números inteiros A, B, C e D.

//Saída
//Mostre a respectiva mensagem após a validação dos valores.

using System;

namespace URI_Iniciante_1035_TesteDeSelecao1 {
    class Program {
        static void Main(string[] args) {
            string[] n = Console.ReadLine().Split(' ');

            int a = int.Parse(n[0]);
            int b = int.Parse(n[1]);
            int c = int.Parse(n[2]);
            int d = int.Parse(n[3]);

            if ((((b > c && d > a) && ((c + d) > (a + b))) && (c > 0 && d > 0)) && (a % 2 == 0)) {
                Console.WriteLine("Valores aceitos");
            }
            else {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
