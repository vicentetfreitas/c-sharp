using System;
namespace URI_Iniciante_1172_SubstituicaoEmVetor1 {
    class Program {
        static void Main(string[] args) {

            int[] vect;
            vect = new int[10];

            for (int i = 0; i < 10; i++) {
                vect[i] = int.Parse(Console.ReadLine());

                if (vect[i] <= 0) {
                    vect[i] = 1;
                }
                Console.WriteLine($"X[{i}] = " + vect[i]);
            }

        }
    }
}
