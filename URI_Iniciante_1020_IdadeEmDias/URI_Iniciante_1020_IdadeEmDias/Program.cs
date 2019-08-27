using System;

namespace URI_Iniciante_1020_IdadeEmDias {
    class Program {
        static void Main(string[] args) {

            int dias = int.Parse(Console.ReadLine());

            int ano, mes,dia;

            ano = dias / 365;
            dias -= ano * 365;

            mes = dias / 30;
            dias -= mes * 30;

            dia = dias / 1;
            dias -= dias * 30;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");



        }
    }
}
