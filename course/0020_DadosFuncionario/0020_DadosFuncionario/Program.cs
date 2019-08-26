using System;
using System.Globalization;

namespace _0020_DadosFuncionario {
    class Program {
        static void Main(string[] args) {
            Console.Write("NUMBER: ");
            int numero = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("WORKED HOUR: ");
            double horaTrabalhada = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("SALARY: ");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double novoSalario = horaTrabalhada * salario;

            Console.WriteLine($"{ numero}");
            Console.WriteLine("R$ "+ novoSalario.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
