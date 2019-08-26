using System;
using System.Globalization;
namespace _0024_ParImparPositivoNegativo {
    class Program {
        static void Main(string[] args) {

            int numero;

            Console.Write("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());

            if ((numero % 2 == 0)) {
                Console.WriteLine("PAR!");
            }
            else {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
