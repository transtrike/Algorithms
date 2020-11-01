using System;

namespace ThePowerSum
{
    class Program
    {
        private static int possibleCombos;

        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine()); //1 <= x <= 1000
            int n = int.Parse(Console.ReadLine()); //2 <= n <= 10

            PowerSum(x, n);

            System.Console.WriteLine(Program.possibleCombos);
        }

        static int PowerSum(int total, int power, int currentNum = 1)
        {
            //x int to sum to Pow( , x)
            //n max number to raise to 
            return 0;
        }
    }
}
