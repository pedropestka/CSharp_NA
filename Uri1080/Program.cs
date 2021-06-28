using System;

namespace Uri1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int pos = 0;


            for (int i = 1; i <= 10; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x > max)
                {
                    max = x;
                    pos = i;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(pos);



            Console.ReadLine();
        }
    }
}
