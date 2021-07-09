using System;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[][] array = BuildArrayFromInput(size);

            Console.WriteLine(SumDiagonals(array));
        }

        static int SumDiagonals(int[][] array)
        {
            int leftDiagonalSum = 0;
            int i = 0;
            int j = 0;

            for (int k = 0; k < array.GetLength(0); k++)
            {
                leftDiagonalSum += array[i][j];
                i++;
                j++;
            }
            
            int rightDiagonalSum = 0;
            i = 0;
            j = array.GetLength(0) - 1;

            for (int k = 0; k < array.GetLength(0); k++)
            {
                rightDiagonalSum += array[i][j];
                i++;
                j--;
            }

            return Math.Abs(rightDiagonalSum - leftDiagonalSum);
        }

        static int[][] BuildArrayFromInput(int arraySize)
        {
            int[][] array = new int [arraySize][];

            for (int i = 0; i < arraySize; i++)
                array[i] = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), int.Parse);

            return array;
        }
    }
}
