using System;
using System.Security.Cryptography.X509Certificates;

namespace Uri1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);
            int z = int.Parse(valores[2]);

            int maior_xy = (x + y + Math.Abs(x - y)) / 2;
            int maior = (maior_xy + z + Math.Abs(maior_xy - z)) / 2;

            Console.WriteLine("O maior é " + maior);








            Console.ReadLine();
        }
    }
}
