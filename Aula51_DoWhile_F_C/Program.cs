using System;
using System.Globalization;

namespace Aula51_DoWhile_F_C
{
    class Program
    {
        static void Main(string[] args)
        {
            string r;

            do
            {
                Console.Write("Digite a temperatura em Celsius: ");
                double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double f = (9 * c) / 5 + 32;
                Console.WriteLine("Equivalente em Fahrenheit: " + f.ToString("F1", CultureInfo.InvariantCulture));

                Console.Write("Deseja repetir (s/n)? ");
                r = Console.ReadLine();
            } while (r == "s");

        }
    }
}
