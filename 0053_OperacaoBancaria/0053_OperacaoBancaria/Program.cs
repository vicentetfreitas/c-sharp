using System;
using System.Globalization;
namespace _0053_OperacaoBancaria {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("========================================");
            Console.WriteLine("            OPERACAO BANCARIA");
            Console.WriteLine("========================================");

            ContaBancaria conta; //Instanciação

            Console.Write("Número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Titular: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n) ? ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 'S' || resposta == 's') {
                Console.Write("Entre com o valor do deposito inicial: R$ ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);//Se Saldo inicial: Contrutor de 3 argumentos
            }
            else {
                conta = new ContaBancaria(numero, titular);// Se não S/Saldo inicial: Contrutor de 2 argumentos

            }

            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.Write("Dados da Conta: ");
            Console.WriteLine();
            Console.WriteLine(conta);
            Console.WriteLine("========================================");
            Console.Write("Entre com o valor para deposito: R$ ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.Write("Entre com o valor do saque: R$ ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.WriteLine("========================================");
        }
    }
}
