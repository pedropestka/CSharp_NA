using System;
using System.Globalization;
namespace Aula44
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int c = 0;
            double soma = 0.0;

            if (x>=0)
            {
                while (x>=0)
                {
                    soma += x;
                    c += 1;
                    x = int.Parse(Console.ReadLine());
                }
                double media = soma / c;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("impossível calcular");
            }



            Console.ReadLine();
        }
    }
}
