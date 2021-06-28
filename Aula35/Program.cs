using System;

namespace Aula35
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, menor;
            //n1 = int.Parse(Console.ReadLine());
            //n2 = int.Parse(Console.ReadLine());
            //n3 = int.Parse(Console.ReadLine());


            string[] entrada = Console.ReadLine().Split(' ');
            n1 = int.Parse(entrada[0]);
            n2 = int.Parse(entrada[1]);
            n3 = int.Parse(entrada[2]);

            if (n1<=n2)
            {
                menor = n1;
            }
            else
            {
                menor = n2;
            }
            if (menor>n3)
            {
                menor = n3;
            }
            Console.WriteLine(menor);

            Console.ReadLine();
        }
    }
}
