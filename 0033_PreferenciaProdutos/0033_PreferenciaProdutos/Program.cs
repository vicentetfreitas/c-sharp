using System;
using System.Globalization;
namespace _0033_PreferenciaProdutos {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("-----------------------");
            Console.WriteLine("PESQUISA DE COMBUSTIVEL");
            Console.WriteLine("1.Álcool");
            Console.WriteLine("2.Gasolina");
            Console.WriteLine("3.Diesel");
            Console.WriteLine("4.Fim");
            Console.WriteLine("-----------------------");
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4) {
                if (tipo == 1) {
                    alcool = alcool + 1;
                }
                else if (tipo == 2) {
                    gasolina = gasolina + 1;
                }
                else if (tipo == 3) {
                    diesel = diesel + 1;
                }

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

        }
    }
}
