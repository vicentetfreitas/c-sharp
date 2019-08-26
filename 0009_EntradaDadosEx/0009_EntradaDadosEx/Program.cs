using System;

namespace _0009_EntradaDadosEx {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite seu nome COMPLETO:");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem em sua casa:");
            string quantQuarto = Console.ReadLine();
            Console.WriteLine("Entre com o preço de um produto:");
            string precoProduto = Console.ReadLine();
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha): ");

            string[] vetorInformacao = Console.ReadLine().Split(' ');
            string a = vetorInformacao[0];
            string b = vetorInformacao[1];
            string c = vetorInformacao[2];

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(quantQuarto );
            Console.WriteLine(precoProduto );
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
