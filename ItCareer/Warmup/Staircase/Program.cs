using System;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintStaircase(n);
        }

        static void PrintStaircase(int n, int x = 1)
        {
            //3 space 1 #
            //2 space 2 #
            //1 space 3 #
            // 0 space 4 #

            if (x > n)
                return;
            string spaces = new string(' ', n - x);
            string hashtags = new string('#', x); 

            if (x == n)
                Console.Write($"{spaces}{hashtags}");
            else
                Console.WriteLine($"{spaces}{hashtags}");
            PrintStaircase(n, x + 1);
        }
    }
}
