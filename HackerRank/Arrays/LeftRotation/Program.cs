using System;
using System.Linq;

namespace LeftRotation
{
	class Program
	{
		static void Main()
		{
			int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			int size = input[0];
			int rotations = input[1];

			int[] rotatedArr = new int[size];
			for (int i = 0; i < size; i++)
			{
				int getElemAt = i + rotations;
				//i = 2
				//getElemAt = 5
				//getElemAt must be 0
				if (getElemAt >= size)
					getElemAt %= size;

				rotatedArr[i] = arr[getElemAt];
			}

			for (int i = 0; i < rotatedArr.Length; i++)
			{
				Console.Write($"{rotatedArr[i]} ");
			}
		}
	}
}
