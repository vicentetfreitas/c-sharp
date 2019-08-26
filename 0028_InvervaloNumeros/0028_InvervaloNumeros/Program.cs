using System;
using System.Globalization;
namespace _0028_InvervaloNumeros {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("---------------------------");
            Console.WriteLine("NUMEROS DENTRO DE INTERVALO");
            Console.WriteLine("([0,25],(25,50],(50,75],(75,100)");
            Console.WriteLine("---------------------------");
            float num;
            Console.WriteLine("Digite um numero: ");
            num = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (num >= 0 && num <= 25) {
                Console.Write("Intervalo entre [0,25]");
            } else if (num > 25 && num <= 50) {
                Console.Write("Intervalo entre (25,50]");
            } else if (num > 50 && num <= 75) {
                Console.Write("Intervalo entre (50,75]");
            } else if (num>75 && num <=100) {
                Console.Write("Intervalo entre (75,100]");
            }
            else {
                Console.Write("Fora do Intervalo");
            }

        }
    }
}
