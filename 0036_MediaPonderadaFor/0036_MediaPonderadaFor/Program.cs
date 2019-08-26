using System;
using System.Globalization;
namespace _0036_MediaPonderadaFor {
    class Program {
        static void Main(string[] args) {

            int i, numMedia;

            Console.Write("Medias a calcular: ");
            numMedia = int.Parse(Console.ReadLine());

            for (i = 1; i <= numMedia; i++) {
                string[] valoresMedia = Console.ReadLine().Split(' ');
                double nota1 = double.Parse(valoresMedia[0], CultureInfo.InvariantCulture);
                double nota2 = double.Parse(valoresMedia[1], CultureInfo.InvariantCulture);
                double nota3 = double.Parse(valoresMedia[2], CultureInfo.InvariantCulture);

                double media = (nota1 * 2.0 + nota2 * 3.0 + nota3 * 5.0) / 10.0;

                Console.Write(media.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
