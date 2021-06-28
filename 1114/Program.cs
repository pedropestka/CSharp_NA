using System;

namespace _1114
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002;
            int tentativa = int.Parse(Console.ReadLine());

            while (tentativa != senha)
            {
                Console.WriteLine("Senha Invalida");
                tentativa = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");





            Console.ReadLine();
        }
    }
}
