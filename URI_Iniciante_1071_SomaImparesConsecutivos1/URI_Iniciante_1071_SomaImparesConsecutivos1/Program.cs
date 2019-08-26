using System;

namespace URI_Iniciante_1071_SomaImparesConsecutivos1 {
    class Program {
        static void Main(string[] args) {

            int a, b, c = 0;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a == b)
                Console.WriteLine(c);
            else if (a < b) {
                for (a += +1; a < b; a++) {
                    if (a % 2 == 1 || a % 2 == -1)
                        c += a;
                }
                Console.WriteLine(c);
            }
            else if (a > b) {
                for (b += +1; b < a; b++) {
                    if (b % 2 == 1 || b % 2 == -1)
                        c += b;
                }
                Console.WriteLine(c);
            }
        }
    }
}
