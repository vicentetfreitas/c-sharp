using System;

namespace _0076_DiteTimePropriedadesOperacoes {
    class Program {
        static void Main(string[] args) {

            DateTime d = new DateTime(2019, 8, 25, 11, 38, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
            Console.WriteLine("==================================");
            Console.WriteLine();

            DateTime d1 = new DateTime(2019, 8, 25, 11, 46, 58);

            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();

            string s5 = d.ToString();

            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine("ToLongDateString: " + s1);
            Console.WriteLine("ToLongTimeString: " + s2);
            Console.WriteLine("ToShortDateString: " + s3);
            Console.WriteLine("ToShortTimeString: " + s4);
            Console.WriteLine("Default/Padrão: " + s5);
            Console.WriteLine("yyyy-MM-dd HH:mm:ss" + s6);
            Console.WriteLine("yyyy - MM - dd HH: mm:ss.fff" + s7);
            Console.WriteLine("==================================");
            Console.WriteLine();

            Console.WriteLine("Operações");
            DateTime d2 = new DateTime(2019, 8, 25, 12, 39, 58);

            DateTime d3 = d2.AddHours(2);
            DateTime d4 = d2.AddMinutes(3);
            DateTime d5 = d2.AddDays(7);

            DateTime d6 = new DateTime(2019, 8, 31, 12, 39, 58);

            d2.Subtract(d6);
            TimeSpan t = d6.Subtract(d1);

            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(t);

        }
    }
}
