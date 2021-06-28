using System;
using System.Globalization;

namespace vetores08
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] alturas = new double[n];
            char[] sexo = new char[n];
            double somaAltMulheres = 0;
            int contHomens = 0;
            int contMulheres = 0;

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                alturas[i] = double.Parse(s[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(s[1]);
                somaAltMulheres += alturas[i];
                if (sexo[i] == 'F')
                {
                    contMulheres++;
                }
                if (sexo[i] == 'M')
                {
                    contHomens++;
                }
            }
            double mediaM = somaAltMulheres / n;
            double menor = alturas[0];
            double maior = alturas[0];

            for (int i = 1; i < n; i++)
            {
                if (menor > alturas[i])
                {
                    menor = alturas[i];
                }
                if (maior < alturas[i])
                {
                    maior = alturas[i];
                }
            }

            Console.WriteLine(menor.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(maior.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(mediaM.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(contHomens);


            Console.ReadLine();
        }
    }
}
