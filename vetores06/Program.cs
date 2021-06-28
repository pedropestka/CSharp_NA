using System;


namespace vetores06
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string[] nomes = new string[n];
            int[] idades = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
            }

            int maisVelho = 0;
            for (int i = 1; i < n; i++)
            {
                if (maisVelho < idades[i])
                {
                    maisVelho = i;
                }
            }

            Console.WriteLine("Pessoa mais velha: " + nomes[maisVelho]);



            Console.ReadLine();
        }
    }
}
