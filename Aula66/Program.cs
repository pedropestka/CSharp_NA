using System;

namespace Aula66
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] M = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    M[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("Diagonal principal:");
            
            for (int i = 0; i < n; i++)
            {
                Console.Write(M[i, i] + " ");
            }
            Console.WriteLine();
            Console.Write("Quantidade de negativos = ");

            int cont_neg = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (M[i,j] < 0)
                    {
                        cont_neg++;
                    }
                }
            }
            Console.WriteLine(cont_neg);

            Console.ReadLine();
        }
    }
}
