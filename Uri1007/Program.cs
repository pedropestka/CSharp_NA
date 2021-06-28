using System;

namespace Uri1007
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c, d, res;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            res = a * b - c * d;

            Console.WriteLine("DIFERENÇA = " + res);




            Console.ReadLine();
        }
    }
}
