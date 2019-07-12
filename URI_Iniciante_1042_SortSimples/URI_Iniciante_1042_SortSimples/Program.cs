using System;

namespace URI_Iniciante_1042_SortSimples {
    class Program {
        static void Main(string[] args) {

            int n1, n2, n3;

            String[] valores = Console.ReadLine().Split(' ');
            n1 = int.Parse(valores[0]);
            n2 = int.Parse(valores[1]);
            n3 = int.Parse(valores[2]);
            //ORDEM CRESCENTE
            if (n1 < n2 && n1 < n3) {
                if (n2 < n3) {
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                }
                else if (n3 < n2) {
                    Console.WriteLine(n1);
                    Console.WriteLine(n3);
                    Console.WriteLine(n2);
                }
            }
            else if (n2 < n1 && n2 < n3) {
                if (n1 < n3) {
                    Console.WriteLine(n2);
                    Console.WriteLine(n1);
                    Console.WriteLine(n3);
                }
                else if (n3 < n1) {
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                    Console.WriteLine(n1);

                }
            }
            else if (n3 < n1 && n3 < n2) {
                if (n2 < n1) {
                    Console.WriteLine(n3);
                    Console.WriteLine(n2);
                    Console.WriteLine(n1);
                }
                else if (n1 < n2) {
                    Console.WriteLine(n3);
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);

                }
            }

            Console.WriteLine();

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
        }
    }
}
