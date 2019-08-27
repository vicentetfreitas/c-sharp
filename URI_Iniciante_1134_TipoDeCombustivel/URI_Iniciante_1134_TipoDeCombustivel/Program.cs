using System;

namespace URI_Iniciante_1134_TipoDeCombustivel {
    class Program {
        static void Main(string[] args) {

            int cod, cont1 = 0, cont2 = 0, cont3 = 0;

            cod = int.Parse(Console.ReadLine());

            while (cod != 4) {
                cod = int.Parse(Console.ReadLine());
                if (cod == 1) {
                    cont1 += 1;
                }
                else if (cod == 2) {
                    cont2 += 1;
                }
                else if (cod == 3) {
                    cont3 += 1;
                }
                else {
                }
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + cont1);
            Console.WriteLine("Gasolina: " + cont2);
            Console.WriteLine("Diesel: " + cont3);

        }
    }
}
