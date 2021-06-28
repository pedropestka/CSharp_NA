using System;

namespace Uri1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j=1; j <= 3; j++)
                {
                    Console.Write(x + " ");
                    x++;
                }
                x++;
                Console.WriteLine("PUM");
            }
            Console.ReadLine();
        }
    }
}
