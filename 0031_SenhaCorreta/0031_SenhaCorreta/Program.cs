using System;

namespace _0031_SenhaCorreta {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Dica: ano atual.");
            Console.Write("SENHA: ");
            int senha = int.Parse(Console.ReadLine());

            if (senha != 2019) {
                
                while (senha != 2019) {
                    Console.WriteLine("Senha Invalida.");
                    Console.Write("Digite Novamente - SENHA: ");
                    senha = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("***Acesso Permitido.***");

        }
    }
}
