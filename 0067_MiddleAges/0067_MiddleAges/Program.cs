using System;

namespace _0067_MiddleAges {
    class Program {
        static void Main(string[] args) {
            double age, sum = 0.0, average;
            int count = 0;

            age = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (age >= 0) {
                sum += age;
                count += 1;
                age = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            if (count == 0) {
                Console.WriteLine("Impossible to calculate");
            }
            else {
                average = sum / count;
                Console.WriteLine(average.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
