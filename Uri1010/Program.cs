using System;
using System.Globalization;

namespace Uri1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string e1 = Console.ReadLine();
            string e2 = Console.ReadLine();

            string[] v1 = e1.Split(' ');
            string[] v2 = e2.Split(' ');

            int cpd_p1 = int.Parse(v1[0]);
            int qnt_p1 = int.Parse(v1[1]);
            double valor_p1 = double.Parse(v1[2], CultureInfo.InvariantCulture);
            
            int cpd_p2 = int.Parse(v2[0]);
            int qnt_p2 = int.Parse(v2[1]);
            double valor_p2 = double.Parse(v2[2], CultureInfo.InvariantCulture);

            double valor_pago = qnt_p1 * valor_p1 + qnt_p2 * valor_p2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valor_pago.ToString("F2", CultureInfo.InvariantCulture));










            Console.ReadLine();
        }
    }
}
