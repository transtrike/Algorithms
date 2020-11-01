using System;

namespace Mini_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Array
                .ConvertAll<string, int>
                (Console.ReadLine().Split(' '), int.Parse);

            long smallest = SumMin(array);
            long biggest = SumMax(array);

            System.Console.Write($"{smallest} {biggest}");
        }

        static long SumMin(int[] array)
        {
            // Sum the min of 4 out of 5 elements
            int biggestNumberIndex = 0;
            long biggestNumber = 0;

            for (int i = 0; i < array.Length; i++)
                if (array[i] >= biggestNumber)
                {
                    biggestNumber = array[i];
                    biggestNumberIndex = i;
                }

            long sum = 0;
            
            for (int i = 0; i < array.Length; i++)
                if (i != biggestNumberIndex)
                    sum += array[i];

            return sum;
        }

        static long SumMax(int[] array)
        {
            // Sum the max of 4 out of 5 elements 
            int smallestNumberIndex = 0;
            long smallestNumber = Int64.MaxValue;

            for (int i = 0; i < array.Length; i++)
                if (array[i] <= smallestNumber)
                {
                    smallestNumber = array[i];
                    smallestNumberIndex = i;
                }

            long sum = 0;

            for (int i = 0; i < array.Length; i++)
                if (i != smallestNumberIndex)
                    sum += array[i];

            return sum;
        }
    }
}
