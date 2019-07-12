using System;
using System.Globalization;
namespace URI_Iniciante_1021_NotasMoedas {
    class Program {
        static void Main(string[] args) {

            double valor, notas;
            double moedas = 0;
            double n100, n50, n20, n10, n5, n2, m1 = 0, m050, m025, m010, m05, m01;

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            moedas = (valor - (int)valor * 100);

            notas = valor;




            n100 = valor / 100;
            n100 = (int)n100;
            valor -= n100 * 100;

            n50 = valor / 50;
            n50 = (int)n50;
            valor -= n50 * 50;

            n20 = valor / 20;
            n20 = (int)n20;
            valor -= n20 * 20;

            n10 = valor / 10;
            n10 = (int)n10;
            valor -= n10 * 10;

            n5 = valor / 5;
            n5 = (int)n5;
            valor -= n5 * 5.0;

            n2 = valor / 2.0;
            n2 = (int)n2;
            valor -= (valor * 2.0);

            m1 = notas;

            m050 = moedas / 50;
            moedas -= (m050 * 50);






            Console.WriteLine("NOTAS:");
            Console.WriteLine(n100.ToString(CultureInfo.InvariantCulture) + " nota(s) de R$ 100.00");
            Console.WriteLine(n50.ToString(CultureInfo.InvariantCulture) + " nota(s) de R$ 50.00");
            Console.WriteLine(n20.ToString(CultureInfo.InvariantCulture) + " nota(s) de R$ 20.00");
            Console.WriteLine(n10.ToString(CultureInfo.InvariantCulture) + " nota(s) de R$ 10.00");
            Console.WriteLine(n5.ToString(CultureInfo.InvariantCulture) + " nota(s) de R$ 5.00");
            Console.WriteLine(n2.ToString(CultureInfo.InvariantCulture) + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            //Console.WriteLine(m1.ToString(CultureInfo.InvariantCulture) + " moeda(s) de R$ 1.00");
             Console.WriteLine(m050.ToString(CultureInfo.InvariantCulture) + " moeda(s) de R$ 0.50");



        }
    }
}
