using System;
using System.Globalization;

namespace _0018_CirculoRaioArea {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pi = 3.14159;
            double areaCirculo = pi * raio * raio;

            Console.Write(" Area do circulo: " + areaCirculo.ToString("F4", CultureInfo.InvariantCulture));


        }
    }
}
