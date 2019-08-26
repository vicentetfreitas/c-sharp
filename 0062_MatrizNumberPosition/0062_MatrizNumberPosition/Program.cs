using System;

namespace _0062_MatrizNumberPosition {
    class Program {
        static void Main(string[] args) {

            int n, m;

            string[] position = Console.ReadLine().Split(' ');

            n = int.Parse(position[0]);
            m = int.Parse(position[1]);

            int[,] mat = new int[n, m];

            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            ///IMPRIMIR MATRIZ
            //for (int i = 0; i < n; i++) {
            //    for (int j = 0; j < m; j++) {
            //        Console.Write(mat[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            Console.WriteLine();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    if (mat[i, j] == number) {
                        if (mat[i, j] == number) {
                            Console.WriteLine("Position " + i + "," + j + ":");
                            if (j > 0) {
                                Console.WriteLine("Left: " + mat[i, j - 1]);
                            }
                            if (i > 0) {
                                Console.WriteLine("Up: " + mat[i - 1, j]);
                            }
                            if (j < n - 1) {
                                Console.WriteLine("Right: " + mat[i, j + 1]);
                            }
                            if (i < m - 1) {
                                Console.WriteLine("Down: " + mat[i + 1, j]);
                            }
                        }
                    }
                }
            }

        }
    }
}
