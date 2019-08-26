using System;
//OBS: 
//I => OVERFLOW: calculo extrapola o limite da váriavel.
namespace _0002_TipoDados {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("0002 - Tipos de Dados");
            Console.WriteLine();
            sbyte a = 100;
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647; 
            long n4 = 2147483648L;
            bool completo = false;
            char genero = 'F';
            float n5 = 4.5f;
            double n6 = 4.5;
            string nomeSobrenome = "Maria Green";
            object obj1 = "Alex Brow";
            object obj2 = 4.5f;

            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            decimal n9 = decimal.MaxValue;

            n1++;
            Console.WriteLine(a);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(nomeSobrenome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
        }
    }
}


