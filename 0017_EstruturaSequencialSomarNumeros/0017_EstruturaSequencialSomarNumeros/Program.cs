using System;

namespace _0017_EstruturaSequencialSomarNumeros {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite N1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite N2: ");
            int n2 = int.Parse(Console.ReadLine());
            int soma;

            soma = n1 + n2;
            Console.Write("SOMA = "+soma);

        }
    }
}
