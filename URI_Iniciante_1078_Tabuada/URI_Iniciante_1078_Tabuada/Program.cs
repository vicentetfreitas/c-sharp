using System;

namespace URI_Iniciante_1078_Tabuada {
    class Program {
        static void Main(string[] args) {
            int n, i;

            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= 10; i++) {
                Console.WriteLine($"{i} x {n} = " + (i * n)); ;

            }
        }
    }
}
