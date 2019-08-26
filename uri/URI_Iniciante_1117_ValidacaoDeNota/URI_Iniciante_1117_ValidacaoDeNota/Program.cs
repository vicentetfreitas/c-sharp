using System;
using System.Globalization;

namespace URI_Iniciante_1117_ValidacaoDeNota {
    class Program {
        static void Main(string[] args) {

            double nota1, nota2, med;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (nota1 < 0.0 || nota1 > 10.0) {
                Console.WriteLine("nota invalida");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (nota2 < 0 || nota2 > 10.0) {
                Console.WriteLine("nota invalida");
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            med = (nota1 + nota2) / 2.0;
            Console.WriteLine("media = " + med.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
