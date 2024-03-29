﻿using System;
using System.Globalization;

namespace _0004_SaidaDadosEx {
    class Program {
        static void Main(string[] args) {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.235467;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1} cujo preço é {preco1}.");
            Console.WriteLine($"{produto2} cujo preço é {preco2}.");

            Console.WriteLine($"Registro: {idade} de idade, código {codigo}e genero {genero}.");
            Console.WriteLine($"Media com 8 casas décimais: {media:F8}");
            Console.WriteLine($"Arredondando (três casas décimais): {media:F3}");
            //Console.WriteLine($"Separador digital invariant culture: {media,CultureInfo.InvariantCulture}");

        }
    }
}
