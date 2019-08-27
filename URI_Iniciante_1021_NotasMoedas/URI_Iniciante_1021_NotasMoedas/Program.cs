using System;
using System.Globalization;
namespace URI_Iniciante_1021_NotasMoedas {
    class Program {
        static void Main(string[] args) {

            double valor;
            int quociente, resto, nota, moeda;
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resto = (int)(valor * 100.0 + 0.5);//Conversão Explicita

            Console.WriteLine("NOTAS:");

            nota = 100;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= (nota * 100);

            nota = 50;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= (nota * 100);

            nota = 20;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= (nota * 100);

            nota = 10;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= (nota * 100);

            nota = 5;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= (nota * 100);

            nota = 2;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= (nota * 100);

            Console.WriteLine("MOEDAS:");

            // o valor de cada moeda deverá ser representado em centavos

            moeda = 100;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
            resto %= moeda;

            moeda = 50;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
            resto %= moeda;

            moeda = 25;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
            resto %= moeda;

            moeda = 10;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
            resto %= moeda;

            moeda = 5;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
            resto %= moeda;

            Console.WriteLine(resto + " moeda(s) de R$ 0.01");



        }
    }
}
