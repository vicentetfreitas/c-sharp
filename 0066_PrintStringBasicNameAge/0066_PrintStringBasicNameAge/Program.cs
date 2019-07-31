using System;
using System.Globalization;

namespace _0066_PrintStringBasicNameAge {
    class Program {
        static void Main(string[] args) {

            string name1, name2;
            int age1, age2;
            double media;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            name1 = vet[0];
            age1 = int.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            name2 = vet[0];
            age2 = int.Parse(vet[1]);

            media = (double)(age1 + age2) / 2.0;

            Console.WriteLine($"A idade média de {name1} e {name2} é de {media.ToString("F1", CultureInfo.InvariantCulture)} anos.");


        }
    }
}
