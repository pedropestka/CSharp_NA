using System;
using System.Globalization;

namespace Aula58_b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];
            string[] s = Console.ReadLine().Split(' ');
            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
                Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
                soma += vet[i];
            }
            Console.WriteLine();
            double media = soma / n;
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
