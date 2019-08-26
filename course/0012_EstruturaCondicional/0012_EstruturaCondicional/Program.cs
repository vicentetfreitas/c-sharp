using System;

namespace _0012_EstruturaCondicional {
    class Program {
        static void Main(string[] args) {

            //Console.WriteLine("Estrutura condicional SIMPLES");
            //int x = 10;
            //Console.WriteLine(" ");
            //Console.WriteLine("Bom dia!");
            //if(x < 5) { 
            //    Console.WriteLine("Bom tarde!");
            //}
            //Console.WriteLine("Bom noite!");
            //Console.WriteLine("----------------   ------------");

            //Console.WriteLine("Estrutura condicional COMPOSTA");
            //Console.WriteLine(" ");
            //Console.WriteLine("Entre com um numero inteiro: ");
            //int x = int.Parse(Console.ReadLine());

            //if (x % 2 == 0) {
            //    Console.WriteLine("Par!");
            //}
            //else {
            //    Console.WriteLine("Impar!");
            //}

            //Console.WriteLine("----------------------------");

            Console.WriteLine("Digite a hora atual: ");
            float horaAtual = float.Parse(Console.ReadLine());

            if (horaAtual < 12) {
                Console.WriteLine("Bom dia!");
            } else if (horaAtual < 18) {
                Console.WriteLine("Boa tarde!");
            }
            else {
                Console.WriteLine("Boa noite");
            }
        }
    }
}
