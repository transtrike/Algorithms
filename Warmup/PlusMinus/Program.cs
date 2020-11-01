using System;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLength = int.Parse(Console.ReadLine());

            int[] arr = new int[arrLength];

            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < input.Length; i++)
                arr[i] = int.Parse(input[i]);

            //arr = [1, 1, 0, -1, -1]
            //n = 5
            /*
                pos/arr.Length
                neg/arr.Length
                zeros/arr.Length
            */

            PlusMinus(arr);
        }

        static void PlusMinus(int[] array)
        {
            int arrayLength = array.Length;
            double positive = 0;
            double negative = 0;
            double zeros = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                if (array[i] > 0)
                    positive++;
                else if (array[i] < 0)
                    negative++;
                else
                    zeros++;
            }

            double positiveRatio = positive / arrayLength;
            double negativeRatio = negative / arrayLength;
            double zeroesRatio   = zeros    / arrayLength;
            System.Console.WriteLine($"{positiveRatio:F6}");
            System.Console.WriteLine($"{negativeRatio:F6}");
            System.Console.WriteLine($"{zeroesRatio:F6}");
        }
    }
}
