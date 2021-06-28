﻿using System;
using System.Globalization;

namespace Aula58
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
            for (int i = 0; i < n; i++)
            {
                Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();
            //soma
            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += vet[i];
            }
            //media
            double media = soma / n;

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadLine();

        }
    }
}
