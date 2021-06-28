using System;
using System.Globalization;

namespace vetores05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] vet = new int[n];

            string[] s = Console.ReadLine().Split(' ');

            int soma = 0;
            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(s[i]);
                if (vet[i]%2 == 0)
                {
                    soma += vet[i];
                    cont++;
                }
            }
            double media = (double)soma / cont;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));


            Console.ReadLine();
        }
    }
}
