using System;
using System.Globalization;

namespace vetores01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double maior = vet[0];
            int posicao = 0;

            for (int i = 1; i < n; i++)
            {
                if (vet[i] > maior )
                {
                    maior = vet[i];
                    posicao = i;
                }
            }
            Console.WriteLine(maior.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);

            Console.ReadLine();
        }
    }
}
