using System;

namespace Uri1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());

            int n100 = valor / 100;
            int r100 = valor % 100;
            int n50 = r100 / 50;
            int r50 = r100 % 50;
            int n20 = r50 / 20;
            int r20 = r50 % 20;
            int n10 = r20 / 10;
            int r10 = r20 % 10;
            int n5 = r10 / 5;
            int r5 = r10 % 5;
            int n2 = r5 / 2;
            int r2 = r5 % 2;
            int n1 = r2;

            Console.WriteLine(n100 + " notas de 100");
            Console.WriteLine(n50 + " notas de 50");
            Console.WriteLine(n20 + " notas de 20");
            Console.WriteLine(n10 + " notas de 10");
            Console.WriteLine(n5 + " notas de 5");
            Console.WriteLine(n2 + " notas de 2");
            Console.WriteLine(n1 + " notas de 1");







            Console.ReadLine();
        }
    }
}
