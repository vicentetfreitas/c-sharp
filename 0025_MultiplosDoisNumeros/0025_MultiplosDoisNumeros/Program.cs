using System;
using System.Globalization;

namespace _0025_MultiplosDoisNumeros {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um numero INTEIRO: ");
            string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);

            if (a % b == 0 || b % a == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
