using System;

namespace vetores03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] vet1 = new int[n];
            int[] vet2 = new int[n];
            int[] vetSoma = new int[n];

            string[] s1 = Console.ReadLine().Split(' ');
            string[] s2 = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vet1[i] = int.Parse(s1[i]);
                vet2[i] = int.Parse(s2[i]);
            }

            for (int i = 0; i < n; i++)
            {
                vetSoma[i] = vet1[i] + vet2[i];
                Console.Write(vetSoma[i] + " ");
            }


            Console.ReadLine();
        }
    }
}
