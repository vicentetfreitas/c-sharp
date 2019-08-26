using System;
using System.Globalization;
namespace _0074_DateTime {
    class Program {
        static void Main(string[] args) {


            DateTime d1 = new DateTime(2019, 08, 25);
            DateTime d2 = new DateTime(2019, 08, 25, 10, 36, 3);
            DateTime d3 = new DateTime(2019, 08, 25, 10, 36, 3, 500);

            DateTime d4 = DateTime.Now; //Horário atual
            DateTime d5 = DateTime.Today; //Zerando a hora
            DateTime d6 = DateTime.UtcNow; //Hora Universal/Greenwich


            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine("Hora Atual: " + d4);
            Console.WriteLine("Zerando a Hora: " + d5);
            Console.WriteLine("Hora Universão/Greenwich: " + d6);
            Console.WriteLine("===================================");
            Console.WriteLine();

            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d9 = DateTime.Parse("15/08/2000");
            DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");

            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine("===================================");
            Console.WriteLine();

            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d11);
            Console.WriteLine(d12);


        }
    }
}
