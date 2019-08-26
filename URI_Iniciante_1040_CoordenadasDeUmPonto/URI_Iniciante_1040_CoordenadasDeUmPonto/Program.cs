using System;
using System.Globalization;
namespace URI_Iniciante_1040_CoordenadasDeUmPonto {
    class Program {
        static void Main(string[] args) {

            String[] pontos = Console.ReadLine().Split(' ');
            double x = double.Parse(pontos[0], CultureInfo.InvariantCulture);
            double y = double.Parse(pontos[1], CultureInfo.InvariantCulture);

            if (x > 0.0 && y > 0.0) {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0) {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0) {
                Console.WriteLine("Q3");
            }
            else if (x > 0.0 && y < 0.0) {
                Console.WriteLine("Q4");
            }
            else if (x == 0 && x == y) {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0 && y != 0.0) {
                Console.WriteLine("Eixo Y");
            }
            else if (x != 0.0 && y == 0.0) {
                Console.WriteLine("Eixo X");

            }

        }
    }
}
