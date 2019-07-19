using System;
using System.Globalization;
namespace URI_Iniciante_1040_Media_3 {
    class Program {
        static void Main(string[] args) {

            double n1, n2, n3, n4, media, nEx, medFinal;

            string[] notas;

            notas = Console.ReadLine().Split(' ');

            n1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
            n4 = double.Parse(notas[3], CultureInfo.InvariantCulture);


            media = ((n1 * 2.0) + (n2 * 3.0) + (n3 * 4.0) + n4) / 10.0;
            

            Console.WriteLine($"Media: {media.ToString(CultureInfo.InvariantCulture)}");

            if (media >= 7.0) {
                Console.WriteLine("Aluno aprovado.");
            }
            if (media < 5.0) {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (media >= 5.0 && media <= 6.9) {
                Console.WriteLine("Aluno em exame.");
                nEx = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                medFinal = (media + nEx) / 2.0;
                if (medFinal >= 5.0) {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + medFinal.ToString(CultureInfo.InvariantCulture).Substring(0, media.ToString("F0").Length - 1));

                }
                else if (medFinal <= 4.9) {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + medFinal.ToString(CultureInfo.InvariantCulture).Substring(0, media.ToString("F0").Length - 1));
                }

            }
        }
    }
}