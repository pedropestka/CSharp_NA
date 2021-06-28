using System;
using System.Globalization;

namespace Uri1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int x = int.Parse(vet[0], CultureInfo.InvariantCulture);
                int y = int.Parse(vet[1], CultureInfo.InvariantCulture);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double div = (double)x / y;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }



            Console.ReadLine();
        }
    }
}
