﻿using System;
using System.Globalization;

namespace Aula15_a
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture)); ;

            Console.ReadLine();
        }
    }
}
