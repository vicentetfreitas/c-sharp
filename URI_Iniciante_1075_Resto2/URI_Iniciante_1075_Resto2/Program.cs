﻿using System;
namespace URI_Iniciante_1075_Resto2 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10000; i++) {
                if (i % n == 2) { Console.WriteLine(i); }

            }
        }
    }
}
