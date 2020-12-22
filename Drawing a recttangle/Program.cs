using System;

namespace Drawing_a_rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter X:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter Y:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("The rectangle is of dimensions" + (x) + "by" + (y));
            for(int i=0; i<(x); i++)
            {
                for (int j = 0; j < (y); j++)
                    Console.Write("*");
                Console.WriteLine("*");

            }
        }
    }
}
