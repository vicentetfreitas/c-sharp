using System;

namespace _0061_MatrizExemplo1 {
    class Program {
        static void Main(string[] args) {

            int n;
            n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Main diagonal: " + mat[i, i] + " ");
            }
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        count++;
                    }
                }
            }
            Console.Write("Negative numbers: " + count);

        }
    }
}
