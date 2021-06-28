using System;
using System.Globalization;

namespace Uri1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("NOTAS:");


            int n100 = (int)entrada / 100;
            double r100 = entrada % 100;
            Console.WriteLine(n100 + " nota(s) de R$ 100.00");

            int n50 = (int)r100 / 50;
            double r50 = r100 % 50;
            Console.WriteLine(n50 + " nota(s) de R$ 50.00");


            int n20 = (int)r50 / 20;
            double r20 = r50 % 20;
            Console.WriteLine(n20 + " nota(s) de R$ 20.00");

            int n10 = (int)r20 / 10;
            double r10 = r20 % 10;
            Console.WriteLine(n10 + " nota(s) de R$ 10.00");


            int n5 = (int)r10 / 5;
            double r5 = r10 % 5;
            Console.WriteLine(n5 + " nota(s) de R$ 5.00");


            int n2 = (int)r5 / 2;
            double r2 = r5 % 2;
            Console.WriteLine(n2 + " nota(s) de R$ 2.00");



            Console.WriteLine("MOEDAS:");


            int m1 = (int)(r2 / 1.00);
            double r1 = (double)(r2 % 1.00);
            Console.WriteLine(m1 + " moeda(s) de R$ 1.00");

            int m050 = (int)(r1 / 0.50);
            double r050 = (double)(r1 % 0.50);
            Console.WriteLine(m050 + " moeda(s) de R$ 0.50");

            int m025 = (int)(r050 / 0.25);
            double r025 = (double)(r050 % 0.25);
            Console.WriteLine(m025 + " moeda(s) de R$ 0.25");

            int m010 = (int)(r025 / 0.10);
            double r010 = (double)(r025 % 0.10);
            Console.WriteLine(m010 + " moeda(s) de R$ 0.10");

            int m005 = (int)(r010 / 0.05);
            double r005 = (double)(r010 % 0.05);
            Console.WriteLine(m005 + " moeda(s) de R$ 0.05");

            int m001 = (int)(r005 / 0.01);
            Console.WriteLine(m001 + " moeda(s) de R$ 0.01");

            Console.ReadLine();
        }
    }
}