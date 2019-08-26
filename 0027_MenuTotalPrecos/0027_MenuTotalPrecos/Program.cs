using System;
using System.Globalization;
namespace _0027_MenuTotalPrecos {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(" ==============================");
            Console.WriteLine(" CODIGO   ESPECIFICACAO   PRECO");
            Console.WriteLine(" ==============================");
            Console.WriteLine(" 1    Cachorro Quente   R$ 4,00");
            Console.WriteLine(" 2    X-Salada          R$ 4,50");
            Console.WriteLine(" 3    X-Bacon           R$ 5,00");
            Console.WriteLine(" 4    Salada Simples    R$ 2,00");
            Console.WriteLine(" 5    Refrigerante      R$ 1,50");
            Console.WriteLine(" ------------------------------");
            Console.Write("COD e QUANTIDADE sequencialmente: ");
            string[] opcoes = Console.ReadLine().Split(' ');

            double total=0;
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
            } else  {
                total = quant * 1.50;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
