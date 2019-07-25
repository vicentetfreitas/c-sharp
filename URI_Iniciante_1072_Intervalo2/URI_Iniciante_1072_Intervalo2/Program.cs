using System;

namespace URI_Iniciante_1072_Intervalo2 {
    class Program {
        static void Main(string[] args) {
            int i, n, x, contIn = 0, contOut = 0;

            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++) {
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20) {
                    contIn++;
                }
                else {
                    contOut++;
                }
            }
            Console.WriteLine($"{contIn} in");
            Console.WriteLine($"{contOut} out");
        }
    }
}
