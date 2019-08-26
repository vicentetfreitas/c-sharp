using System;
using System.Globalization;

namespace _0021_CalculaPeca {
    class Program {
        static void Main(string[] args) {

            int cod1, cod2, quant1, quant2;
            double preco1, preco2, total;

            //Recebe PEÇA-1
            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            quant1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2],CultureInfo.InvariantCulture );

            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            quant2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco1 * quant1 + preco2 * quant2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
