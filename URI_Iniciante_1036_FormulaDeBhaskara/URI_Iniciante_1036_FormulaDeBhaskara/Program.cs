using System;
using System.Globalization;

namespace URI_Iniciante_1036_FormulaDeBhaskara {
    class Program {
        static void Main(string[] args) {

            string[] coeficiente = Console.ReadLine().Split(' ');

            double a = double.Parse(coeficiente[0], CultureInfo.InvariantCulture);
            double b = double.Parse(coeficiente[1], CultureInfo.InvariantCulture);
            double c = double.Parse(coeficiente[2], CultureInfo.InvariantCulture);
            
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1, x2;

            if (delta < 0 || a == 0) {
                Console.WriteLine("Impossivel calcular");
            }
            else {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine("R1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }

        }

    }
}

