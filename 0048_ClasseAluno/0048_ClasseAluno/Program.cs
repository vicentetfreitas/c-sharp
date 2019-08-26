using System;
using System.Globalization; 
namespace _0048_ClasseAluno {
    class Program {
        static void Main(string[] args) {

            Aluno studant;
            studant = new Aluno();

            Console.Write("Nome do AlUNO: ");
            studant.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            studant.Nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            studant.Nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            studant.Nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = "+ studant.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (studant.Aprovado()) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + studant.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }
        

            
        }
    }
}
