using System;

namespace _0039_DivisoresNumero {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                if (n % i == 0) {
                    Console.WriteLine(i);
                }
            }
    }
}
