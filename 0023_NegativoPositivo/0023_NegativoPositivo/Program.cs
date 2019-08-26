using System;

namespace _0023_NegativoPositivo {
    class Program {
        static void Main(string[] args) {
            int numero;

            Console.WriteLine("Digite um numero INTEIRO: ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0) {
                Console.WriteLine("NAO NEGATIVO");
            }
            else {
                Console.WriteLine("POSITIVO"); 
            }
        }
    }
}
