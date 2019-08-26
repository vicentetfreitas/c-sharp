using System;
using System.Globalization;

namespace _0030_CalculaImpostoRenda {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("         RENDA                   IMPOSTO DE RENDA");
            Console.WriteLine("DE 0.00 A R$2000.00                     ISENTO");
            Console.WriteLine("DE 0.00 A R$2000.01 ATÉ R$3000.00         8%");
            Console.WriteLine("DE 0.00 A R$3000.01 ATÉ R$4500.00        18%");
            Console.WriteLine("ACIMA DE R$4500.00                       28%");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("SALÁRIO: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (salario <= 2000.0) {
                imposto = 0.0;
            }
            else if (salario <= 3000.0) {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0) {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0) {
                Console.WriteLine("Isento");
            }
            else {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
