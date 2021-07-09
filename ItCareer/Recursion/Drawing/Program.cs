using System;

namespace Drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Draw(n);
        }

        static void Draw(int n)
        {
            System.Console.WriteLine(new string('*', n));

            if (n != 1)
                Draw(n - 1);

            System.Console.WriteLine(new string('#', n));
        }
    }
}
