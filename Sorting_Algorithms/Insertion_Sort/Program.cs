using System;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]
            {
                23, 4, 6, 3, 7, 5, 1, 0
            };

            Sort(array);

            foreach (var item in array)
                Console.Write($"{item}\n");
        }

        static void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i]; // takes current element
                int j = i - 1; //backwards iterator

                while (j > -1 && array[j] > key)
                {
                    
                    array[j + 1] = array[j]; // copies next element in current element
                    j--;
                }
                array[j + 1] = key; //next element = current element 
            }
        }
    }
}
