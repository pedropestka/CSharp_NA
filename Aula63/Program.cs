using System;

namespace Aula63
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int l = int.Parse(s[0]);
            int c = int.Parse(s[1]);

            int[,] M = new int[l, c];

            for (int i = 0; i < l; i++)
            {
                string[] entradaLinha = Console.ReadLine().Split(' ');
                for (int j = 0; j < c; j++)
                {
                    M[i, j] = int.Parse(entradaLinha[j]);
                }
            }

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(M[i, j] + " ");
                }
                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }
}
