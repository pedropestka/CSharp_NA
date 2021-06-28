using System;

namespace Uri1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());
            int anos, meses, dias;

            anos = entrada / 365;
            int anos_resto = entrada % 365;

            meses = anos_resto / 30;
            dias = anos_resto % 30;

            Console.WriteLine(anos);
            Console.WriteLine(meses);
            Console.WriteLine(dias);




            Console.ReadLine();
        }
    }
}
