using System;
//Conversão implicita:
//Casting:
namespace _0007_ConversaoImplicitaCasting {
    class Program {
        static void Main(string[] args) {

            //Conversão Implícita de tipos
            float x = 4.5f;
            double y = x;

            //Casting
            double a;
            float b;
            a = 5.1;
            b = (float)a;

            Console.WriteLine(y);
            Console.WriteLine(b);
        }
    }
}
