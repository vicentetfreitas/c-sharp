using System;
namespace URI_Iniciante_1115_Quadrante {
    class Program {
        static void Main(string[] args) {

            String[] pontos = Console.ReadLine().Split(' ');
            int x = int.Parse(pontos[0]);
            int y = int.Parse(pontos[1]);
            if (x > 0.0 && y > 0.0) {
                Console.WriteLine("primeiro");
            }
            else if (x < 0.0 && y > 0.0) {
                Console.WriteLine("segundo");
            }
            else if (x < 0.0 && y < 0.0) {
                Console.WriteLine("terceiro");
            }
            else if (x > 0.0 && y < 0.0) {
                Console.WriteLine("quarto");
            }
            while (x != 0 && y != 0) {

                
                pontos = Console.ReadLine().Split(' ');
                x = int.Parse(pontos[0]);
                y = int.Parse(pontos[1]);
                if (x > 0.0 && y > 0.0) {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0.0 && y > 0.0) {
                    Console.WriteLine("segundo");
                }
                else if (x < 0.0 && y < 0.0) {
                    Console.WriteLine("terceiro");
                }
                else if (x > 0.0 && y < 0.0) {
                    Console.WriteLine("quarto");
                }

            }



        }
    }
}


