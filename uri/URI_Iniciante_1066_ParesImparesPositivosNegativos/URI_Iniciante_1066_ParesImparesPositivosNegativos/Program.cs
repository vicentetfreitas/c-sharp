using System;

namespace URI_Iniciante_1066_ParesImparesPositivosNegativos {
    class Program {
        static void Main(string[] args) {

            int i, contPar = 0, contImpar = 0, contPositivo = 0, contNegativo = 0;

            for (i = 0; i < 5; i++) {

                int n = int.Parse(Console.ReadLine());

                //PAR
                if (n % 2 == 0) {
                    contPar += 1;
                }
                //IMPAR
                if (n % 2 != 0) {
                    contImpar += 1;
                }
                //POSITIVO
                if (n < 0) {
                    contNegativo += 1;
                }
                //NEGATIVO
                if (n > 0) {
                    contPositivo += 1;
                }
            }

            Console.WriteLine(contPar + " valor(es) par(es)");
            Console.WriteLine(contImpar + " valor(es) impar(es)");
            Console.WriteLine(contPositivo + " valor(es) positivo(s)");
            Console.WriteLine(contNegativo + " valor(es) negativo(s)");


        }
    }
}
