using System;
using System.Globalization;

namespace vetores04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }
            
            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vet[i];
            }
            double media = soma / n;
            Console.WriteLine("Média: " + media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0; i < n; i++)
            {
                if (vet[i]<media)
                {
                    Console.Write(vet[i].ToString("F2", CultureInfo.InvariantCulture) + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
