using System;

namespace URI_Iniciante_1070_SeisNumerosImpares {
    class Program {
        static void Main(string[] args) {

            int n, i = 0, x = 6;

            n = int.Parse(Console.ReadLine());

            for (i = n; i < (n + (2 * x)); i ++) {
                int impar;
                if (i % 2 == 0) {
                    impar = i + 1;
                    Console.WriteLine(impar);
                }
                else {
                    impar = i;
                    Console.WriteLine(impar);
                }
            }
        }
    }
}
