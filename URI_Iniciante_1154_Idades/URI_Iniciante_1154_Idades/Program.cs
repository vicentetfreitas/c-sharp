using System;
using System.Globalization;
namespace URI_Iniciante_1154_Idades {
    class Program {
        static void Main(string[] args) {
            int somaIdade = 0, contIdade = 0;
            double med;

            int idade = int.Parse(Console.ReadLine());
            while (idade >= 0) {
                somaIdade += idade;
                contIdade += 1;
                idade = int.Parse(Console.ReadLine());

            }
            med = (double)somaIdade / contIdade;

            Console.WriteLine(med.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
