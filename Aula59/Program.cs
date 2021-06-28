using System;
using System.Globalization;

namespace Aula59
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] idade = new int[n];
            double[] altura = new double[n];
            string[] nome = new string[n];
            double somaAltura = 0;
            int cont = 0;


            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                idade[i] = int.Parse(s[1]);
                altura[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
                somaAltura += altura[i];
                if (idade[i]<16)
                {
                    cont++;
                }
            }
            double mediaAltura = somaAltura / n;
            double tx_menores = (double)cont / n * 100.0;

            Console.WriteLine("Altura média: " + mediaAltura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pessoas com menos de 16 anos: " + tx_menores.ToString("F1", CultureInfo.InvariantCulture) + "%");

            Console.ReadLine();
        }
    }
}
