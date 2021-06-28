using System;

namespace Aula67
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int l = int.Parse(s[0]);
            int c = int.Parse(s[1]);

            int[,] M = new int[l, c];
            int[] V = new int[l];

            for (int i = 0; i < l; i++)
            {
                string[] z = Console.ReadLine().Split(' ');
                int somaLinha = 0;
                for (int j = 0; j < c; j++)
                {
                    M[i, j] = int.Parse(z[j]);
                    somaLinha += M[i, j];
                }
                V[i] = somaLinha;
            }

            for (int i = 0; i < l; i++)
            {
                Console.WriteLine(V[i]);
            }

            Console.ReadLine();
        }
    }
}
