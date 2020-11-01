using System;
using System.Collections.Generic;

namespace _0_1_Knapsack_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxWeight = 5;
            List<int> itemsWeight = new List<int>() { 5, 3, 4, 2 };
            List<int> itemsValue = new List<int>() { 60, 50, 70, 30 };

            int[,] matrix = new int[itemsValue.Count, maxWeight + 1];

            Console.WriteLine("Max Weight: " + maxWeight);
            Console.WriteLine("Rows/Item: " + matrix.GetLength(0));
            Console.WriteLine("Cols/Zero-Indexed Capacity: " + matrix.GetLength(1));

            KnapsackProblem(matrix, itemsWeight, itemsValue);

            PrintMatrix(matrix);
        }

        static void KnapsackProblem(int[,] matrix, List<int> itemsWeight, List<int> itemsValue)
        {
            for (int itemIndex = 0; itemIndex < matrix.GetLength(0); itemIndex++)
            {
                for (int capacity = 1; capacity < matrix.GetLength(1); capacity++)
                {
                    int including = 0;
                    int excluding = 0;
                    //Calc based on the upper value in matrix if item index != 0
                    if (itemIndex != 0)
                        excluding = matrix[itemIndex - 1, capacity];
                    
                    //Item weight < current capacity
                    if (itemsWeight[itemIndex] <= capacity)
                    {
                        if (itemIndex == 0)
                            including = itemsValue[itemIndex];
                        else
                            including = itemsValue[itemIndex] + matrix[itemIndex - 1, capacity - itemsWeight[itemIndex]];
                    }

                    //Set value
                    if (including >= excluding)
                        matrix[itemIndex, capacity] = including;
                    else
                        matrix[itemIndex, capacity] = excluding;
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int capacity = 0; capacity < matrix.GetLength(0); capacity++)
            {
                for (int itemIndex = 0; itemIndex < matrix.GetLength(1); itemIndex++)
                    Console.Write($"{matrix[capacity, itemIndex]} ");

                Console.Write("\n");
            }
            Console.WriteLine(new string('-', 20));
        }
    }
}
