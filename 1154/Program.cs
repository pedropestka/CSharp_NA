using System;
using System.Globalization;

namespace _1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());
            int contador = 0;
            int soma = 0;

            while (idade >= 0)
            {
                contador += 1;
                soma += idade;
                idade = int.Parse(Console.ReadLine());
            }
            double media = (double)soma / contador;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
