using System;
using System.Globalization;

namespace Uri1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            int c = 0;
            int r = 0;
            int s = 0;
            

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int q = int.Parse(vet[0], CultureInfo.InvariantCulture);
                string tipo = vet[1];

                if (tipo == "C")
                {
                    c += q;
                }
                else if (tipo == "R")
                {
                    r += q;
                }
                else if (tipo == "S")
                {
                    s += q;
                }
            }
            total = c + r + s;

            Console.WriteLine("Total: " + total);
            Console.WriteLine("Total de coelhos: " + c);
            Console.WriteLine("Total de ratos: " + r);
            Console.WriteLine("Total de sapos: " + s);

            double tx_c = (double)c / total * 100;           

            double tx_r = (double)r / total * 100;

            double tx_s = (double)s / total * 100;

            Console.WriteLine("Percentual de coelhos: " + tx_c.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + tx_r.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + tx_s.ToString("F2", CultureInfo.InvariantCulture) + " %");

            Console.ReadLine();
        }
    }
}
