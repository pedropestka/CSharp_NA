using System;
using System.Globalization;

namespace Uri1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double x = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double y = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double z = double.Parse(vet[2], CultureInfo.InvariantCulture);

                double media = (2 * x + 3 * y + 5 * z) / 10;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
