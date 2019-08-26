using System;
namespace URI_Iniciante_1173_PreenchimentoDeVetor1 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[10];

            vector[0] = n;

            for (int i = 1; i <= 9; i++) {
                vector[i] = vector[i - 1]*2;
            }
            for (int i = 0; i <= 9; i++) {
                Console.WriteLine($"N[{i}] = {vector[i]}");
            }
        }
    }
}
