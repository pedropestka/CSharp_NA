using System;
using System.Globalization;

namespace Aula34
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, r1, r2;

            string[] v = Console.ReadLine().Split(' ');
            a = double.Parse(v[0]);
            b = double.Parse(v[1]);
            c = double.Parse(v[2]);

            delta = b * b - 4 * a * c;

            if (a==0 || delta<=0)
            {
                Console.WriteLine("Impossível calcular");
            }
            else
            {
                r1 = (-1 * b + Math.Sqrt(delta)) / (2.0 * a);
                r2 = (-1 * b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}
