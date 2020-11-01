using System;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] arr = ParseToIntArr(input);

            SumArray(arr);
        }

        static void SumArray(int[] array)
        {   
            long sum = 0;

            foreach (var num in array)
                sum += num;

            System.Console.WriteLine(sum);
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
