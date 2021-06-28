using System;

namespace vetores02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] vet = new int[n];
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(s[i]);
            }

            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                if (vet[i]%2 == 0)
                {
                    Console.Write(vet[i] + " ");
                    cont++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(cont);

            Console.ReadLine();
        }
    }
}