using System;
using System.Globalization;

namespace URI_Iniciante_1043_Triangulo {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');
            double a = double.Parse(valores[0]);
            double b = double.Parse(valores[1]);
            double c = double.Parse(valores[2]);

            if ((b<c)<a && a<(b+c)) {


            }
        }
    }
}
