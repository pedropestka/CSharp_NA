using System;
using System.Globalization;

namespace Udemy_PrimeirosPassos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, soma;
            soma = 0;
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());
                soma += x;
            }
            Console.WriteLine(soma);
            Console.ReadLine();


        }
    }
}


