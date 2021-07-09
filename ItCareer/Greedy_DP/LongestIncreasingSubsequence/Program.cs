using System;
using System.Collections.Generic;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] sequence = new int[n];
            for (int i = 0; i < n; i++)
                sequence[i] = int.Parse(Console.ReadLine());

            int[] result = new int[sequence.Length];
            result[0] = 1;

            LIS(sequence, result);

            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine($"Index: {i}; Result: {result[i]}");
            //}

            int res = 1;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] > res)
                    res = result[i];
            }
            Console.Write("Longest Increasing Subsequence: " + res);
        }

        static void LIS(int[] sequence, int[] result, int index = 1)
        {
            if (index == sequence.Length)
                return;

            //index - current index of subproblem
            //i - current index of subproblem's array
            result[index] = 1;
            for (int i = 0; i < index; i++)
            {
                if (sequence[i] < sequence[index])
                {
                    int prevBest = result[i] + 1;
                    if (prevBest >= result[index])
                        result[index] = prevBest++;
                }
            }

            LIS(sequence, result, index + 1);
        }
    }
}
