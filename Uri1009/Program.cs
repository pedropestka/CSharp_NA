using System;
using System.Globalization;

namespace Uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double receber;

            receber = (double) salario + (vendas * 0.15);

            Console.WriteLine("TOTAL = R$ " + receber.ToString("F2", CultureInfo.InvariantCulture));



            Console.ReadLine();


        }
    }
}
