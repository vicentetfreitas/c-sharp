using System;
using System.Globalization;

namespace _0043_PessoaMaisVelha {
    class Program {
        static void Main(string[] args) {

            Pessoa pessoa1,pessoa2;

            Console.WriteLine("Dados da Primeira Pessoa: ");
            pessoa1 = new Pessoa();
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Dados da Segunda Pessoa: ");
            pessoa2 = new Pessoa();
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (pessoa1.Idade > pessoa2.Idade) {
                Console.WriteLine("Pessoa mais velha: "+pessoa1.Nome);
            }
            else if (pessoa1.Idade == pessoa2.Idade) {
                Console.WriteLine("Mesma Idade.");
            }
            else {
                Console.WriteLine("Pessoa mais velha: "+pessoa2.Nome);
            }

        }
    }
}
