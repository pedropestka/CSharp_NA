using System;
using System.Globalization;

namespace Aula36
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos = int.Parse(Console.ReadLine());
            double valor = 50.0;

            if (minutos>100)
            {
                valor = valor + (minutos - 100)*2;
            }
            
            Console.WriteLine(valor.ToString("F2", CultureInfo.InvariantCulture));










            //int minutos = int.Parse(Console.ReadLine());
            //int excedente;
            //double valor;

            //if (minutos <= 100)
            //{
            //    valor = 50;
            //}
            //else
            //{
            //    excedente = minutos - 100;
            //    valor = 50 + excedente * 2;
            //}
            //Console.WriteLine(valor);



            Console.ReadLine();
        }
    }
}
