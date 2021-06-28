using System;

namespace Aula57
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < n; i++)
            {
                if (v[i]<0)
                {
                    Console.WriteLine(v[i]);
                }
                
            }






            Console.ReadLine();
        }
    }
}
