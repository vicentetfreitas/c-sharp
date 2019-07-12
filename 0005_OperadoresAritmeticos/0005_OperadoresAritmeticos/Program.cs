﻿using System;

namespace _0005_OperadoresAritmeticos {
    class Program {
        static void Main(string[] args) {

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 2;
            double n4 = 10.0 / 8;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine("----------------------");
            Console.WriteLine("Formúla de Baskára");
            Console.WriteLine("");
            double a = 1.0, b = -3.0, c = -4.0;
            //double delta = b * b - 4.0 * a * c;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine($"Resultado da formúla: {delta}");
            Console.WriteLine($"Raiz da equação x1: {x1}");
            Console.WriteLine($"Raiz da equação x2: {x2}");

        }
    }
}
