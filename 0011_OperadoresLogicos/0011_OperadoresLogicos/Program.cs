﻿using System;

namespace _0011_OperadoresLogicos {
    class Program {
        static void Main(string[] args) {

            bool c1 = 2 > 3 && 4 != 5;
            bool c2 = 2 > 3 || 4 != 5;
            bool c3 = !(2 > 3) && 4 != 5;
            bool c4 = 10 < 5;
            bool c5 = c1 || c2 && c3;
            Console.WriteLine($"E => {c1}");
            Console.WriteLine($"OU => {c2}");
            Console.WriteLine($"Não => {c3}");

            Console.WriteLine(c5);
        }
    }
}
