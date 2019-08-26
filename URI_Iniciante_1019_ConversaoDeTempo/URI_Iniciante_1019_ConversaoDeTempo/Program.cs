//Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica,
//e informe-o expresso no formato horas:minutos:segundos.

//Entrada
//O arquivo de entrada contém um valor inteiro N.

//Saída
//Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, 
//conforme exemplo fornecido.


using System;

namespace URI_Iniciante_1019_ConversaoDeTempo {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            int s, m, h;

            h = n / 3600;
            m = n % 3600 / 60;
            s = n % 60;

            Console.WriteLine(h + ":" + m + ":" + s);

        }
    }
}
