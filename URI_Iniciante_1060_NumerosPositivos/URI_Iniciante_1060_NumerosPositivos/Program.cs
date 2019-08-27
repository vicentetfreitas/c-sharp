using System;
using System.Globalization;
namespace URI_Iniciante_1060_NumerosPositivos {
    class Program {
        static void Main(string[] args) {

            int i, contPositivo = 0;

            for (i = 0; i < 6; i++) {
                double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (n > 0) {
                    contPositivo += 1;
                }
            }
            Console.WriteLine(contPositivo +" valores positivos");
        }
    }
}
