using System;
using System.Globalization;

namespace URI_Iniciante_1045_TiposDeTriangulo {
    class Program {
        static void Main(string[] args) {

            double a, b, c;
            string[] valores = Console.ReadLine().Split(' ');

            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //Ordem Decrescente
            if (a > b && a > c) {

                //se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
                if (a >= (b + c)) {
                    Console.WriteLine("NAO FORMA TRIANGULO");
                }
                //se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
                if (Math.Pow(a, 2) == ((Math.Pow(b, 2)) + (Math.Pow(c, 2)))) {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                //se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
                if (Math.Pow(a, 2) > ((Math.Pow(b, 2)) + (Math.Pow(c, 2)))) {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                if ((b * b) < (a * a) + (c * c) || (c * c) < (a * a) + (b * b)) {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

            }
            else if (b > a && b > c) {


                //se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
                if (b >= (a + c)) {
                    Console.WriteLine("NAO FORMA TRIANGULO");
                }
                //se B2 = A2 + B2, apresente a mensagem: TRIANGULO RETANGULO
                if (Math.Pow(b, 2) == ((Math.Pow(a, 2)) + (Math.Pow(b, 2)))) {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                //se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
                if (Math.Pow(b, 2) > ((Math.Pow(a, 2)) + (Math.Pow(b, 2)))) {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                if ((a * a) < (b * b) + (c * c) || (c * c) < (a * a) + (b * b)) {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

            }
            else if (c > a && c > b) {

                //se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
                if (c >= (b + a)) {
                    Console.WriteLine("NAO FORMA TRIANGULO");
                }
                //se C2 = A2 + B2, apresente a mensagem: TRIANGULO RETANGULO
                if (Math.Pow(c, 2) == ((Math.Pow(b, 2)) + (Math.Pow(a, 2)))) {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                if (Math.Pow(c, 2) > ((Math.Pow(b, 2)) + (Math.Pow(a, 2)))) {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                if ((a * a) < (b * b) + (c * c) || (b * b) < (a * a) + (c * c)) {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

            }

        }
    }
}
