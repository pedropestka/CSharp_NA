using System;
using System.Globalization;

namespace Aula54
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            double[] B = new double[A];

            for (int i = 0; i < A; i++)
            {
                double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                B[i] = x;
            }

            for (int j = 0; j < A; j++)
            {
                Console.WriteLine(B[j].ToString("F1", CultureInfo.InvariantCulture));
            }






            Console.ReadLine();
        }
    }
}
