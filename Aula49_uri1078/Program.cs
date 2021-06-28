using System;

namespace Aula49_uri1078
{
    class Program
    {
        static void Main(string[] args)
        {

            int tabuada = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " x " + tabuada + " = " + i * tabuada);
            }

            Console.ReadLine();




        }
    }
}
