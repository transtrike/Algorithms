using System;
using System.Linq;

namespace TwoD_Array_DS
{
	class Program
	{
		static void Main()
		{
			//All indexes at which an hourglass could exist
			int[] validIndexes = new[]
				{ 0, 1, 2, 3, 6, 7, 8, 9, 12, 13, 14, 15, 18, 19, 20, 21 };

			//User input:
			int[,] arr = new int[6, 6];
			for (int row = 0; row < 6; row++)
			{
				string[] stringArray = Console.ReadLine().Split(' ');

				for (int col = 0; col < stringArray.Length; col++)
				{
					arr[row, col] = int.Parse(stringArray[col]);
				}
			}

			//Calculations
			int maxSum = 0;
			for (int i = 0; i < validIndexes.Length; i++)
			{
				int sum = SumValuesAtStartIndex(validIndexes[i], arr);
				if (sum > maxSum)
					maxSum = sum;
			}

			Console.WriteLine(maxSum);
		}

		private static int SumValuesAtStartIndex(int startIndex, int[,] arr)
		{
			int row = startIndex / 6;
			int col = startIndex % 6;

			// \/
			// a b c
			//   d
			// e f g
			int a = arr[row, col];
			int b = arr[row, col + 1];
			int c = arr[row, col + 2];
			int d = arr[row + 1, col + 1];
			int e = arr[row + 2, col];
			int f = arr[row + 2, col + 1];
			int g = arr[row + 2, col + 2];

			return a + b + c + d + e + f + g;
		}
	}
}
