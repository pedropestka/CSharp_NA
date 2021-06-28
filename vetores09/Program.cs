using System;
using System.Globalization;

namespace vetores09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nome = new string[n];
            double[] pcompra = new double[n];
            double[] pvenda = new double[n];
            double[] lucro = new double[n];

            double scompra = 0;
            double svenda = 0;


            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                pcompra[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                pvenda[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
                lucro[i] = (pvenda[i] / pcompra[i] - 1) * 100;
                scompra += pcompra[i];
                svenda += pvenda[i];
            }

            int l10 = 0;
            int l1020 = 0;
            int l20 = 0;

            for (int i = 0; i < n; i++)
            {
                if (lucro[i] < 10.00)
                {
                    l10++;
                }
                else if (lucro[i] >= 10.0 && lucro[i] <= 20.00)
                {
                    l1020++;
                }
                else
                {
                    l20++;
                }
            }

            double lucrot = svenda - scompra;
            Console.WriteLine("Lucro abaixo de 10%: " + l10);
            Console.WriteLine("Lucro entre 10% e 20% : " + l1020);
            Console.WriteLine("Lucro acima de 20%: " + l20);
            Console.WriteLine("Valor total de compras: " + scompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de vendas: " + svenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucrot.ToString("F2", CultureInfo.InvariantCulture));

            






            Console.ReadLine();
        }
    }
}
