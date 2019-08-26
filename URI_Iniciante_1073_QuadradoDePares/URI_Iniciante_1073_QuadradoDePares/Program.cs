using System;
using System.Globalization;
namespace URI_Iniciante_1073_QuadradoDePares {
    class Program {
        static void Main(string[] args) {

            int i, num, contPar = 0;

            num = int.Parse(Console.ReadLine());

            for (i = 1; i <= num; i++) {

                if (i % 2 == 0) {
                    Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
                }

            }

        }
    }
}
