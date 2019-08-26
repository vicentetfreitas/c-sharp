using System;
using System.Globalization; //Operador de Décimal

namespace _0015_EstruturaRepeticao {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            while (numero >=0) {
                double raiz = Math.Sqrt(numero);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro Número: ");
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número NEGATIVO!!!");
            
        }
    }
}
