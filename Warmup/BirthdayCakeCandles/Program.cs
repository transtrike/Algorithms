using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfCandles = int.Parse(Console.ReadLine());
            int[] candles = new int[sizeOfCandles];
            candles = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), int.Parse);

            System.Console.WriteLine(NumberOfTallestCandles(candles));
        }

        static int NumberOfTallestCandles(int[] candles)
        {
            int biggestNumber = 0;

            for (int i = 0; i < candles.Length; i++)
                if (candles[i] > biggestNumber)
                    biggestNumber = candles[i];

            int numberOfBiggestCandles = 0;
            for (int i = 0; i < candles.Length; i++)
                if (candles[i] == biggestNumber) numberOfBiggestCandles++;

            return numberOfBiggestCandles;
        }
    }
}
