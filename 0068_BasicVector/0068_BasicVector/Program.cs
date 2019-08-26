using System;
using System.Globalization;
namespace _0068_BasicVector {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];

            for (int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < n; i++) {
                Console.Write("[" + vect[i] + "]");
            }

        }
    }
}
