using System;
using System.Linq;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll<string, int>(input, int.Parse);

            System.Console.WriteLine(Sum(arr));
        }

        static int Sum(int[] arr, int index = 0)
        {
            if(index == arr.Length - 1)
                return arr[index];
                

            return arr[index] + Sum(arr, index + 1); 
        }
    }
}
