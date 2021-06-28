using System;
namespace Aula43_uri1113
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int x = int.Parse(s[0]);
            int y = int.Parse(s[1]);
            while (x != y){
                if (x < y){
                    Console.WriteLine("Crescente");
                }
                else{
                    Console.WriteLine("Decrescente");
                }
                s = Console.ReadLine().Split(' ');
                x = int.Parse(s[0]);
                y = int.Parse(s[1]);
            }
            Console.ReadLine();
        }
    }
}
