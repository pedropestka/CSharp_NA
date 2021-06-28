using System;
namespace Aula50_Uri1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int max, min;
            if (x > y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }
            int soma = 0;

            for (int i = min + 1; i < max; i++)
            {
                if (i%2!=0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);
            Console.ReadLine();


        }
    }
}
