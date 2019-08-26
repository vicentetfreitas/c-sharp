using System;
using System.Globalization;
namespace _0044_SalarioMedioFuncionario {
    class Program {
        static void Main(string[] args) {

            Funcionario func1, func2;
            double mediaSalarial;
            func1 = new Funcionario();
            func2 = new Funcionario();

            Console.WriteLine("Dados do Primeiro Funcionário: ");
            Console.WriteLine("Nome do Funcionário-1: ");
            func1.Nome = Console.ReadLine();
            Console.Write("Salário Funcionário-1: R$ ");
            func1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Segundo Funcionário: ");
            Console.WriteLine("Nome do Funcionário-2: ");
            func2.Nome = Console.ReadLine();
            Console.Write("Salário Funcionário-2: R$ ");
            func2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mediaSalarial = (func1.Salario + func2.Salario) / 2;

            Console.WriteLine("Salário Médio: R$ "+ mediaSalarial.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
