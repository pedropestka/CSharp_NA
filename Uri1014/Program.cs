using System;
using System.Globalization;

namespace Uri1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia = int.Parse(Console.ReadLine());
            double combustivel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double consumo;
            consumo = distancia / combustivel;

            Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture) + " km/l");









            Console.ReadLine();
        }
    }
}
