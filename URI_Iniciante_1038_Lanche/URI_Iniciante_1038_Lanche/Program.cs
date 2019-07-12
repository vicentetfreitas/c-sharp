using System;
using System.Globalization;

namespace URI_Iniciante_1038_Lanche {
    class Program {
        static void Main(string[] args) {
            string[] opcoes = Console.ReadLine().Split(' ');

            double total = 0;
            double cd = int.Parse(opcoes[0]);
            double quant = int.Parse(opcoes[1]);

            if (cd == 1) {
                total = quant * 4.00;
            }
            else if (cd == 2) {
                total = quant * 4.50;
            }
            else if (cd == 3) {
                total = quant * 5.00;
            }
            else if (cd == 4) {
                total = quant * 2.00;
            }
            else {
                total = quant * 1.50;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

