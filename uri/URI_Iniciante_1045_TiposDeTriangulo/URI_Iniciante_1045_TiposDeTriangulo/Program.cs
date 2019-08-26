using System;
using System.Globalization;

namespace URI_Iniciante_1045_TiposDeTriangulo {
    class Program {
        static void Main(string[] args) {

            double num1, num2, num3;
            string[] valores = Console.ReadLine().Split(' ');

            num1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            num2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            num3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double a, b, c;

            //Ordem Decrescente
            //Se num1 = A(maior)
            if (num1 > num2 && num1 > num3) {
                a = num1;
                if (num2 > num3) {
                    b = num2;
                    c = num3;
                }
                else {
                    b = num3;
                    c = num2;
                }
            }
            else if (num2 > num1 && num2 > num3) {
                a = num2;
                if (num1 > num3) {
                    b = num1;
                    c = num3;
                }
                else {
                    b = num3;
                    c = num1;
                }
            }
            else {
                a = num3;
                if (num1 > num2) {
                    b = num1;
                    c = num2;
                }
                else {
                    b = num2;
                    c = num1;
                }
            }
            if (a >= b + c) {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else {
                if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2)) {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2)) {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if (a == b && b == c) {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (a == b || a == c || b == c) {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }

            }

        }
    }
}
