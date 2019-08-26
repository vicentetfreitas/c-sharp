using System;
using System.Collections.Generic;
namespace _0063_Sets {
    class Program {
        static void Main(string[] args) {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);


            B.Add(3);
            B.Add(4);
            B.Add(5);
            B.Add(15);
            B.Add(20);

            //Para cada inteiro x dentro do conjunto B
            Console.WriteLine("Conjunto A");
            foreach (int x in A) {
                Console.WriteLine(x);
            }
            Console.WriteLine("Conjunto B");
            foreach (int x in B) {
                Console.WriteLine(x);
            }

            Console.WriteLine("Verifica se o numero digitado estar condito no conjunto B.");
            Console.WriteLine();
            Console.Write("Digite um valor inteiro: ");
            int n = int.Parse(Console.ReadLine());

            //Elementos que estão contidos no conjunto B
            if (B.Contains(n)) {
                Console.WriteLine(n + " pertence ao conjunto B.");
            }
            else {
                Console.WriteLine(n + " não pertence ao conjunto B.");
            }
            Console.WriteLine("=======================================");
            Console.WriteLine();
            //Remover o elemento do conjunto B
            Console.WriteLine("Remover elemento do conjunto B");
            B.Remove(4);
            foreach (int x in B) {
                Console.WriteLine(x);
            }
            Console.WriteLine("=======================================");
            //Diferença entre Conjuntos
            Console.WriteLine("Diferença entre o conjunto A e B: A-B");
            A.ExceptWith(B);
            foreach (int x in A) {
                Console.WriteLine(x);
            }
            //União de Conjuntos A e B
            Console.WriteLine("União do Conjunto A e B");
            A.UnionWith(B);
            foreach (int x in A) {
                Console.WriteLine(x);
            }
            Console.WriteLine("====================================");
            //Interseção de Conjuntos A e B
            Console.WriteLine("Interserção de A e B");
            A.IntersectWith(B);
            foreach (int x in A) {
                Console.WriteLine(x);
            }

        }
    }
}
