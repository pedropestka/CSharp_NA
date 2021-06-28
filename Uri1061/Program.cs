using System;
using System.Xml.Schema;

namespace Uri1061
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada_dia_inicial = Console.ReadLine().Split(' ');
            int dia_inicial = int.Parse(entrada_dia_inicial[1]);

            string[] entrada_hora_inicial = Console.ReadLine().Split(' ');
            int hora_inicial = int.Parse(entrada_hora_inicial[0]);
            int minutos_inicial = int.Parse(entrada_hora_inicial[2]);
            int segundos_inicial = int.Parse(entrada_hora_inicial[4]);
            

            string[] entrada_dia_final = Console.ReadLine().Split(' ');
            int dia_final = int.Parse(entrada_dia_final[1]);

            string[] entrada_hora_final = Console.ReadLine().Split(' ');
            int hora_final = int.Parse(entrada_hora_final[0]);
            int minutos_final = int.Parse(entrada_hora_final[2]);
            int segundos_final = int.Parse(entrada_hora_final[4]);



            int inicio, fim, duracao;
            inicio = (dia_inicial - 1) * 24 * 60 * 60 + hora_inicial * 60 * 60 + minutos_inicial * 60 + segundos_inicial;
            fim = (dia_final - 1) * 24 * 60 * 60 + hora_final * 60 * 60 + minutos_final * 60 + segundos_final;
            duracao = fim - inicio;

            int d, h, m, s, resto;

            d = duracao / (24 * 60 * 60);
            resto = duracao % (24 * 60 * 60);

            h = resto / (60 * 60);
            resto = resto % (60 * 60);

            m = resto / 60;

            s = resto % 60;


            Console.WriteLine(d);
            Console.WriteLine(h);
            Console.WriteLine(m);
            Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}
