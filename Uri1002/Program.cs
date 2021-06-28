using System;
using System.Globalization;

namespace Uri1002
{
    class Program
    {
        static void Main(string[] args)
        {


            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double a;
            double n = 3.14159;


            a = n * raio*raio;

            Console.WriteLine("A=" + a.ToString("F4", CultureInfo.InvariantCulture));





            Console.ReadLine();
        }
    }
}
