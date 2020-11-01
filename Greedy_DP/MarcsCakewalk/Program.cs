using System;
using System.Collections.Generic;

namespace MarcsCakewalk
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            List<int> calories = new List<int>(input.Length);

            for (int i = 0; i < input.Length; i++)
                calories.Add(int.Parse(input[i]));

            calories.Sort();

            Console.WriteLine(DetermineMiles(calories));
        }

        static long DetermineMiles(List<int> calories)
        {
            // 2^j * c - miles to maintain his weight
            //3 cupcakes -> [5, 10, 7]
            //Greedy - always take from biggest to smallest
            int j = 0;
            double milesToRun = 0;
            for (int i = calories.Count - 1; i > -1; i--)
            {
                milesToRun += Math.Pow(2, j) * calories[i];
                j++;
            }

            return (long)milesToRun;
        }
    }
}
