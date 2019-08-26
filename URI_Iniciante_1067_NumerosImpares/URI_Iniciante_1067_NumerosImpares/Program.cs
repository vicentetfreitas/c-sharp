using System;

namespace URI_Iniciante_1067_NumerosImpares {
    class Program {
        static void Main(string[] args) {
            int i, x;
            x = int.Parse(Console.ReadLine());

            if (x >= 1 && x <= 1000) {
                for (i = 1; i <= x; i++) {

                    if (i % 2 != 0) {
                        Console.WriteLine(i);
                    }


                }
            }
        }
    }
}
