using System;
namespace Uri1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    Console.WriteLine("NULO");
                }
                else
                {
                    if (x % 2 == 0)
                    {
                        Console.Write("PAR ");
                    }
                    else
                    {
                        Console.Write("ÍMPAR ");
                    }

                    if (x > 0)
                    {
                        Console.WriteLine("POSITIVO");
                    }
                    else
                    {
                        Console.WriteLine("NEGATIVO");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
