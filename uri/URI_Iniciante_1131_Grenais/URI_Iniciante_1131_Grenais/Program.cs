using System;

namespace URI_Iniciante_1131_Grenais {
    class Program {
        static void Main(string[] args) {

            int novoGrenal = 1;
            int contGrenal = 0, contVitoriaInter = 0, contVitoriaGremio = 0, empate = 0;
            while (novoGrenal == 1) {
                string[] grenal = Console.ReadLine().Split(' ');

                int internacional = int.Parse(grenal[0]);
                int gremio = int.Parse(grenal[1]);

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());
                //Quantidade de Grenais
                contGrenal += 1;//Vitorias do Internacional
                if (internacional > gremio) {
                    contVitoriaInter += 1;

                }
                else if (internacional < gremio) {// Vitorias do Gremio
                     contVitoriaGremio += 1;
                }
                else {//Empates
                     empate += 1;
                }
            }
            Console.WriteLine(contGrenal + " grenais");
            Console.WriteLine("Inter:" + contVitoriaInter);
            Console.WriteLine("Gremio:" + contVitoriaGremio);
            Console.WriteLine("Empates:" + empate);
            if (contVitoriaInter > contVitoriaGremio) {
                Console.WriteLine("Inter venceu mais");
            }
            else if (contVitoriaInter < contVitoriaGremio) {
                Console.WriteLine("Gremio venceu mais");
            }
            else {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}
