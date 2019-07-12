using System;

namespace _0034_IntervaloNumerosImpar {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um numero inteiro X: ");

            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
