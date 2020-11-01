using System;
using System.Collections.Generic;

namespace Binary_Search
{
    class BinarySearch
    {
        public BinarySearch() => Run();

        private void Run()
        {
            List<int> array = GetArray();

            //For Binary Search to work, the array/list has to be sorted
            array.Sort();

            int numberToSearchFor = GetNumberToSearchFor();
            int numberIndex = BinarySearchMethod(array, numberToSearchFor, 0, array.Count - 1);

            if (numberIndex == -1)
            {
                System.Console.WriteLine("Number not found!");
            }
            else
            {
                System.Console.WriteLine("Number found!");
                System.Console.WriteLine("Index: " + numberIndex);
            }
        }

        private List<int> GetArray()
        {
            List<int> list = null;

            System.Console.WriteLine("Input how many numbers you want to supply: ");
            int n = int.Parse(System.Console.ReadLine());

            if (n <= 0)
            {
                System.Console.WriteLine("Please supply positive non-zero number");
                Environment.Exit(1);
            }
            else
                list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(System.Console.ReadLine());

                list.Add(number);
            }

            return list;
        }

        private int GetNumberToSearchFor()
        {
            System.Console.WriteLine("Input the number you want to search for: ");
            return int.Parse(System.Console.ReadLine());
        }

        private int BinarySearchMethod(List<int> list, int number, int minIndex, int maxIndex)
        {
            //count = 5
            //arr -> 0 - 4 
            //middle = 0 + (4 - 0) / 2 = 2
            int middleIndex = minIndex + (maxIndex - minIndex) / 2;

            if (minIndex > maxIndex)
                return -1;

            else if (number == list[middleIndex])
                return middleIndex;

            else if (number > list[middleIndex])
                return BinarySearchMethod(list, number, middleIndex + 1, maxIndex);

            else if (number < list[middleIndex])
                return BinarySearchMethod(list, number, minIndex, middleIndex - 1);

            return -1;
        }
    }
}