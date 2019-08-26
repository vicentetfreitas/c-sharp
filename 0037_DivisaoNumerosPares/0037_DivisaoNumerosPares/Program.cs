using System;
using System.Globalization;

namespace _0037_DivisaoNumerosPares {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("N: ");
            int n = int.Parse(Console.ReadLine());
            int i;
            for(i = 1; i <= n; i++) {
                string[] line = Console.ReadLine().Split(' ');
                double n1 = double.Parse(line[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(line[1], CultureInfo.InvariantCulture);
                
                if (n2 == 0.0) {
                    Console.WriteLine("Divisão Impossível..");
                }
                double div = n1 / n2;
                Console.WriteLine(div);
            }
        }
    }
}
