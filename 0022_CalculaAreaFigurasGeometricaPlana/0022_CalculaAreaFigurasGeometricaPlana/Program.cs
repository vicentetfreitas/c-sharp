using System;
using System.Globalization;

namespace _0022_CalculaAreaFigurasGeometricaPlana {
    class Program {
        static void Main(string[] args) {
            double a, b, c, areaTriangulo, areaCirculo,pi,areaTrapezio,areaQuadrado,areaRetangulo;
            pi = 3.14159;

            string[] valores = Console.ReadLine().Split(' ');
            a = double.Parse(valores[0],CultureInfo.InvariantCulture);
            b = double.Parse(valores[1],CultureInfo.InvariantCulture);
            c = double.Parse(valores[2],CultureInfo.InvariantCulture);

            areaTriangulo = (a * c) / 2;
            areaCirculo = pi * c * c;
            areaTrapezio = ((a + b) * c) / 2;
            areaQuadrado = b * b;
            areaRetangulo = a * b;

            Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture ));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3",CultureInfo.InvariantCulture));

        }
    }
}
