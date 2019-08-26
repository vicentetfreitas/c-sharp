using System;
using System.Globalization;
namespace _0035_IntervaloQuantidadeDigitada {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite N: ");
            int n = int.Parse(Console.ReadLine());
            int i,valor;
            int dIntervalo =0, fIntervalo=0;
            Console.WriteLine("");
            for (i = 1; i <= n; i++) {
                Console.Write(i+": " );
                valor = int.Parse(Console.ReadLine());
                if (valor >= 10 && valor <= 20) {
                    dIntervalo += 1;
                }
                else {
                    fIntervalo += 1;
                }
            }
            Console.WriteLine(dIntervalo +" in");
            Console.WriteLine(fIntervalo + " out");
        }
    }
}
