using System;

namespace _0058_CalculadoraSoma {
    class Program {
        static void Main(string[] args) {

            //int s1 = Calculadora.Soma(new int[] { 2, 3 });
            //int s2 = Calculadora.Soma(new int[] { 2, 4, 3 });

            int s1 = Calculadora.Soma(2,3);
            int s2 = Calculadora.Soma(10,20,30,40,50);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
