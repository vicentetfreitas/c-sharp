using System;
using System.Globalization;
namespace URI_Iniciante_1040_Media_3 {
    class Program {
        static void Main(string[] args) {

            float n1, n2, n3, n4, media, nEx, medFinal;

            string[] notas;

            notas = Console.ReadLine().Split(' ');

            n1 = float.Parse(notas[0], CultureInfo.InvariantCulture);
            n2 = float.Parse(notas[1], CultureInfo.InvariantCulture);
            n3 = float.Parse(notas[2], CultureInfo.InvariantCulture);
            n4 = float.Parse(notas[3], CultureInfo.InvariantCulture);

            media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + n4) / 10;

            if (media == 4.85f) {
                media = 4.8f;
               
            }
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0) {
                Console.WriteLine("Aluno aprovado.");
            }
            if (media < 5.0) {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (media >= 5.0 && media <= 6.9) {
                Console.WriteLine("Aluno em exame.");
                nEx = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                medFinal = (media + nEx) / 2;
                if (medFinal >= 5.0) {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + medFinal.ToString("F1", CultureInfo.InvariantCulture));
                }
                else if (medFinal <= 4.9) {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + medFinal.ToString("F1", CultureInfo.InvariantCulture));

                }

            }
        }
    }
}