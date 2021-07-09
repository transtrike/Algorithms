using System;

namespace AVeryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            long[] arr = ParseToLongArr(input);

            LongSum(arr);
        }

        static void LongSum(long[] array)
        {
            long sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];

            System.Console.Write(sum);

            System.
        }

        static long[] ParseToLongArr(string[] array)
        {
            long[] arr = new long[array.Length];
            for (int i = 0; i < array.Length; i++)
                arr[i] = long.Parse(array[i]);

            return arr;
        } 
    }
}
