using System;

namespace Uri1132
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int min, max, soma = 0;

            if (x > y)
            {
                min = y;
                max = x;
            }
            else
            {
                min = x;
                max = y;
            }

            for (int i = min; i <= max; i++)
            {
                if (i % 13 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);





            Console.ReadLine();
        }
    }
}
