using System;
using System.Globalization;
namespace _0049_CircuferenciaEsfera {
    class Calculadora {
        public static double Pi = 3.14;
        public static double Circuferencia(double r) {
            return 2 * Pi * r;
        }
        public static double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}
