using System;
using System.Globalization;

namespace Aula33
{
    class Program
    {
        static void Main(string[] args)
        {

            double n1, n2, soma;

            Console.WriteLine("Digite a nota 1...");
            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a nota 2...");
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = (n1 + n2);

            Console.WriteLine("Nota Final = " + soma.ToString("F1", CultureInfo.InvariantCulture));

            if (soma<60)
            {
                Console.WriteLine("Reprovado!");
            }


            Console.ReadLine();
        }
    }
}
