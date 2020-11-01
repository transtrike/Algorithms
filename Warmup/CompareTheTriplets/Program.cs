using System;

namespace CompareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alise -> a[0 - 2]
            //Bob   -> b[0 - 2]

            //if a[i] > b[i] -> Alice +1
            //if a[i] < b[i] -> Bob +1
            //if a[i] = b[i] -> Nothing

            //Input -> array for a and b 
            //Output -> array [AlisePoints, BobPoints]

            int[] a = ParseToIntArr(Console.ReadLine().Split(' '));
            int[] b = ParseToIntArr(Console.ReadLine().Split(' '));

            CompareTriplets(a, b);
        }

        static void CompareTriplets(int[] a, int[] b)
        {
            int[] points = new int[2];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > b[i])
                    points[0]++;
                else if (a[i] < b[i])
                    points[1]++;
            }

            System.Console.Write($"{points[0]} {points[1]}");
        }

        static int[] ParseToIntArr(string[] array)
        {
            int[] arr = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                arr[i] = int.Parse(array[i]);

            return arr;
        }
    }
}
