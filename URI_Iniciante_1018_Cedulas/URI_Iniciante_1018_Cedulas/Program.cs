﻿using System;

namespace URI_Iniciante_1018_Cedulas {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(n);

            int n100 = (n/100);
            n  -= (n100 * 100);

            int n50 = n / 50;
            n -= n50 * 50;

            int n20 = n / 20;
            n -= n20 * 20;

            int n10 = n / 10;
            n -= n10 * 10;

            int n5 = n / 5;
            n -= n5 * 5;

            int n2 = n / 2;
            n -= n2 * 2;

            int n1 = n / 1;
            n -= n1 * 1;

            Console.WriteLine(n100 + " nota(s) de R$ 100,00");
            Console.WriteLine(n50 + " nota(s) de R$ 50,00");
            Console.WriteLine(n20 + " nota(s) de R$ 20,00");
            Console.WriteLine(n10 + " nota(s) de R$ 10,00");
            Console.WriteLine(n5 + " nota(s) de R$ 5,00");
            Console.WriteLine(n2 + " nota(s) de R$ 2,00");
            Console.WriteLine(n1 + " nota(s) de R$ 1,00");

        }
    }
}
