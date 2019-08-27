using System;

namespace URI_Iniciante_1065_ParesEntreCincoNumeros {
    class Program {
        static void Main(string[] args) {
            int i, valores;
            int contPares = 0;
            for (i = 0; i < 5; i++) {
                valores = int.Parse(Console.ReadLine());
                if (valores % 2 == 0) {
                    contPares += 1;
                }
            }
            Console.WriteLine(contPares+ " valores pares");
        }
    }
}
