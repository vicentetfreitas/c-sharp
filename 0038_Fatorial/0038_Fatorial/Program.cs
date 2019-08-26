using System;

namespace _0038_Fatorial {
    class Program {
        static void Main(string[] args) {

            Console.Write("NUMERO: ");
            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= n; i++) {
                fat = fat * i;
            }

            Console.WriteLine(fat);
        }
    }
}
