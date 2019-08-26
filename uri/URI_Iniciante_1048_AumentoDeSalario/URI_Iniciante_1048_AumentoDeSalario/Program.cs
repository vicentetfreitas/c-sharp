using System;
using System.Globalization;
namespace URI_Iniciante_1048_AumentoDeSalario {
    class Program {
        static void Main(string[] args) {

            double salario, reajusteGanho, novoSalario, percente;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario > 0.00 && salario <= 400.00) {

                reajusteGanho = (salario / 100.0) * 15;
                novoSalario = salario + reajusteGanho;
                percente = ((novoSalario / salario) * 100.0) - 100.0;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percente.ToString("F0", CultureInfo.InvariantCulture) + " %");

            }
            else if (salario > 400.00 && salario <= 800.00) {
                reajusteGanho = (salario / 100.0) * 12;
                novoSalario = salario + reajusteGanho;
                percente = ((novoSalario / salario) * 100.0) - 100.0;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percente.ToString("F0", CultureInfo.InvariantCulture) + " %");
            }
            else if (salario > 800.00 && salario <= 1200.00) {
                reajusteGanho = (salario / 100.0) * 10;
                novoSalario = salario + reajusteGanho;
                percente = ((novoSalario / salario) * 100.0) - 100.0;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percente.ToString("F0", CultureInfo.InvariantCulture) + " %");
            }
            else if (salario > 1200.00 && salario <= 2000.00) {
                reajusteGanho = (salario / 100.0) * 7;
                novoSalario = salario + reajusteGanho;
                percente = ((novoSalario / salario) * 100.0) - 100.0;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percente.ToString("F0", CultureInfo.InvariantCulture) + " %");
            }
            else if (salario > 2000.00) {
                reajusteGanho = (salario / 100.0) * 4;
                novoSalario = salario + reajusteGanho;
                percente = ((novoSalario / salario) * 100.0) - 100.0;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percente.ToString("F0", CultureInfo.InvariantCulture) + " %");
            }
        }
    }
}
