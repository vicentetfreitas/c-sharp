﻿using System;

namespace URI_Iniciante_1044_Multiplos {
    class Program {
        static void Main(string[] args) {

            string[] multiplos = Console.ReadLine().Split(' ');

            int a = int.Parse(multiplos[0]);
            int b = int.Parse(multiplos[1]);

            if (a % b == 0 || b % a == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}
