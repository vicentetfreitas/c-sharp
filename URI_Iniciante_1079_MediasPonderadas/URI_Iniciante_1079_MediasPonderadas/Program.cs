using System;
using System.Globalization;
namespace URI_Iniciante_1079_MediasPonderadas {
    class Program {
        static void Main(string[] args) {

            double media, nota1, nota2, nota3;
            int n;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string[] notas = Console.ReadLine().Split(' ');
                nota1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
                nota2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
                nota3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
                media = ((2 * nota1) + (3 * nota2) + (5 * nota3)) / 10;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }


        }
    }
}
