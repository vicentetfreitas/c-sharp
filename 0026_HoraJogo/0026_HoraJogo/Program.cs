using System;

namespace _0026_HoraJogo {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Hora inicial e a hora final do jogo respectivamente: ");
            string[] horas = Console.ReadLine().Split(' ');

            double horaInicial = double.Parse(horas[0]);
            double horaFinal = double.Parse(horas[1]);
            double horaJogo;

            if (horaFinal < horaInicial) {
                horaJogo = horaFinal - horaInicial;
            }
            else {
                 horaJogo= 24 - (horaFinal - horaInicial);
            }
            Console.WriteLine("O JOGO DUROU " + horaJogo + "H(s).");
        }
    }
}
