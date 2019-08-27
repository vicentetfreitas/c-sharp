using System;

namespace URI_Iniciante_1046_TempoDeJogo {
    class Program {
        static void Main(string[] args) {

            string[] horas = Console.ReadLine().Split(' ');


            int horaIncial = int.Parse(horas[0]);
            int horaFinal = int.Parse(horas[1]);

            int horaDoJogo = (horaFinal - horaIncial);


  

            if (horaDoJogo < 0) {

                horaDoJogo = 24 + (horaFinal - horaIncial);

            }
            else {

            }
            if (horaFinal == horaIncial) {

                Console.WriteLine("O JOGO DUROU 24 HORA(S)");

            }

            else {
                Console.WriteLine($"O JOGO DUROU {horaDoJogo} HORA(S)");
            }


        }
    }
}
