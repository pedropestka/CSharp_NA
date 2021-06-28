using System;
namespace _1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int contador = 0;
            int soma5 = 0;

            while (x != 0)
            {
                if (x % 2 != 0)
                {
                    x += 1;
                }
                while (contador < 5)
                {
                    soma5 += x;
                    contador += 1;
                    x += 2;
                }
                Console.WriteLine(soma5);
                x = int.Parse(Console.ReadLine());
                contador = 0;
                soma5 = 0;
            }
        }
    }
}
