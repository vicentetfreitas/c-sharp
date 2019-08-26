using System;
using System.Globalization;

namespace _0064_GroundArea {
    class Program {
        static void Main(string[] args) {

            double width, length, squareMeterValue, area, groundPrice;

            width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            length = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            squareMeterValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = width * length;
            groundPrice = area * squareMeterValue;

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRICE = " + groundPrice.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
