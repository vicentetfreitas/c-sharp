using System;
using System.Globalization;
namespace _0065_RectangleAreaPerimeterDiagonal {
    class Program {
        static void Main(string[] args) {

            double recBase, recHeight, area, perimeter, diagonal;

            recBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            recHeight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = recBase * recHeight;
            perimeter = 2 * (recBase + recHeight);
            diagonal = Math.Sqrt(Math.Pow(recBase, 2) + Math.Pow(recHeight, 2));

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETER = " + perimeter.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
