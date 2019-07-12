using System;

namespace URI_Iniciante_1047_TempoDeJogoComMinutos {
    class Program {
        static void Main(string[] args) {
            string[] tempo = Console.ReadLine().Split(' ');
            int horaInicial, horaFinal, minInicial, minFinal, minutos, hora, horaDeJogo, minDeJogo;

            minutos = 60;
            hora = minutos;

            horaInicial = int.Parse(tempo[0]);
            minInicial = int.Parse(tempo[1]);
            horaFinal = int.Parse(tempo[2]);
            minFinal = int.Parse(tempo[3]);

            horaDeJogo = (horaFinal - horaInicial);
            Console.WriteLine(horaDeJogo);

            if (horaDeJogo == 0) {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else if (horaDeJogo >= 0 && horaDeJogo <= 24) {

            }

            //if (horaDeJogo > 0 && horaDeJogo < 24) {

            //    Console.WriteLine($"O JOGO DUROU {horaDeJogo} HORA(S) E {minuto} MINUTO(S)");
            //}
            //else if (horaDeJogo == 0 && horaDeJogo == 24) {
            //    Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            //}

            //Console.WriteLine(hora);
            //Console.WriteLine(minuto);
            //Console.WriteLine(horaDeJogo);
            //Console.WriteLine(minDeJogo);


        }
    }
}
