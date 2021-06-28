using System;
using System.Globalization;

namespace Uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int id_func = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double v = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double s = h * v;

            Console.WriteLine("NUMBER = " + id_func);
            Console.WriteLine("SALARY = U$ " + s.ToString("F2",CultureInfo.InvariantCulture));




            Console.ReadLine();
        }
    }
}
