using System;
using System.Globalization;
namespace URI_Iniciante_1064_PositivosMedia {
    class Program {
        static void Main(string[] args) {

            int i, contPositivo = 0;

            double valores, mediaValoresPositivos = 0, soma = 0;
            for (i = 0; i < 6; i++) {
                valores = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (valores > 0) {
                    contPositivo += 1;
                    soma += valores;
                }
                mediaValoresPositivos = soma / contPositivo;
            }
            Console.WriteLine(contPositivo + " valores positivos");
            Console.WriteLine(mediaValoresPositivos.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
