using System;
using System.Globalization;
namespace _0029_QuadranteXeY {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite X e Y respectivamente: ");
            string[] quad = Console.ReadLine().Split(' ');

            float x = float.Parse(quad[0],CultureInfo.InvariantCulture);
            float y = float.Parse(quad[1], CultureInfo.InvariantCulture);

            if (x==0.0 && y==0.0) {
                Console.WriteLine("Origem");
            }
            else if (x > 0.0 && y > 0.0) {
                Console.WriteLine("Q1");
            } else if (x < 0.0 && y > 0.0) {
                Console.WriteLine("Q2");
            } else if (x < 0.0 && y < 0.0) {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0) {
                Console.WriteLine("Q4");
            } else if (x==0) {
                Console.WriteLine("Eixo Y");

            }else if(y == 0) {
                Console.WriteLine("Eixo X");
            }
        }
    }
}
