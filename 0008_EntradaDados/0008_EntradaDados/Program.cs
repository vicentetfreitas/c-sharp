using System;

namespace _0008_EntradaDados {
    class Program {
        static void Main(string[] args) {

           string frase = Console.ReadLine();
           string x = Console.ReadLine();
           string y = Console.ReadLine();
           string z = Console.ReadLine();

           //string s = Console.ReadLine();
           string[] v = Console.ReadLine().Split(' ');
           string a=v[0];
           string b=v[1];
           string c=v[2];

            Console.WriteLine($"Você digitou: {frase}");
            Console.WriteLine($"Você digitou: {x}");
            Console.WriteLine($"Você digitou: {y}");
            Console.WriteLine($"Você digitou: {z}");
            Console.WriteLine($"Você digitou: {a}");
            Console.WriteLine($"Você digitou: {b}");
            Console.WriteLine($"Você digitou: {c}");
        }
    }
}
