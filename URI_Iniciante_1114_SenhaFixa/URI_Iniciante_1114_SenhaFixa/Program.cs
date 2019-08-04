using System;

namespace URI_Iniciante_1114_SenhaFixa {
    class Program {
        static void Main(string[] args) {


            int senha = int.Parse(Console.ReadLine());

            if (senha != 2002) {

                while (senha != 2002) {
                    Console.WriteLine("Senha Invalida");
                    senha = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
