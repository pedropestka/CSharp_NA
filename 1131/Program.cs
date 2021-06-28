using System;

namespace _1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int golsInter, golsGremio, totalGrenais, x, vitoriaInter, vitoriaGremio, empate;
            string[] vet;
            totalGrenais = 0;
            x = 1;
            vitoriaInter = 0;
            vitoriaGremio = 0;
            empate = 0;

            while (x==1)
            {
                vet = Console.ReadLine().Split(' ');
                golsInter = int.Parse(vet[0]);
                golsGremio = int.Parse(vet[1]);
                if (golsInter>golsGremio)
                {
                    vitoriaInter += 1;
                }
                else if (golsInter<golsGremio)
                {
                    vitoriaGremio += 1;
                }
                else
                {
                    empate += 1;
                }
                totalGrenais += 1;
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(totalGrenais + " grenais");
            Console.WriteLine("Inter:" + vitoriaInter);
            Console.WriteLine("Gremio:" + vitoriaGremio);
            Console.WriteLine("Empates:" + empate);
            if (vitoriaInter>vitoriaGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (vitoriaInter < vitoriaGremio)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }
            Console.ReadLine();
        }
    }
}
