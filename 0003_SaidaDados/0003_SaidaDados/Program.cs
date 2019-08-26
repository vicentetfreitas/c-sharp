using System;
using System.Globalization;

namespace _0003_SaidaDados {
    class Program {
        static void Main(string[] args) {
            Console.Write("Bom dia");
            Console.WriteLine("Boa tarde");
            Console.WriteLine("Boa noite");
            Console.WriteLine("-----------------------");
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";
            bool completo = false;
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(completo);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); //Ponto ao invés de virgula

            Console.WriteLine("-----------------------");

            Console.WriteLine("{0} tem {1} anos e tem o sexo {2}.",nome, idade, genero);
            Console.WriteLine($"{nome} tem {idade} anos e tem o sexo {genero}");
            Console.WriteLine($"{nome} tem o saldo de {saldo:F2} reais.");

        }
    }
}
