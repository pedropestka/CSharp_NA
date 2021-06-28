using System;

namespace Uri1097
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i+=2)
            {
                for (int j = i+6; j >= (i+4); j--)
                {
                    Console.WriteLine("I = " + i + " J = " + j);
                }
            }






            Console.ReadLine();
        }
    }
}



//I = 1 J = 7
//I = 1 J = 6
//I = 1 J = 5

//I = 3 J = 9
//I = 3 J = 8
//I = 3 J = 7...

//I = 9 J = 15
//I = 9 J = 14
//I = 9 J = 13