using System;

namespace LargestPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrSizeAndK = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

            Swap(array, arrSizeAndK[1]);
        }

        private static void Swap(int[] array, int allowedSwaps)
        {
            
        }
    }
}
