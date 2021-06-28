using System;

namespace Uri1133
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int min, max;

            if (x<y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }

            for (int i = min+1; i < max; i++)
            {
                if (i%5 == 2 || i%5 == 3)
                {
                    Console.WriteLine(i);
                }
            }



            Console.ReadLine();
        }
    }
}
