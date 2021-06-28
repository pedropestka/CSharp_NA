using System;

namespace Aula60
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            string[] vet = new string[n];

            for (int i = 0; i < n; i++)
            {
                vet[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes Lidos: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vet[i]);
            }


            Console.ReadLine();
        }
    }
}
