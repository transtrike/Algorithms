using System;
using System.Linq;

namespace EnormousInputTest
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine()
				.Split(' ')
				.ToArray();

			int[] parsedInput = new int[2];
			for (int i = 0; i < 2; i++)
				parsedInput[i] = int.Parse(input[i]);

			int numbersDivisible = 0;
			for (int i = 0; i < parsedInput[0]; i++)
			{
				uint number = uint.Parse(Console.ReadLine());

				if (number % parsedInput[1] == 0)
					numbersDivisible++;
			}

			Console.WriteLine(numbersDivisible);
		}
	}
}
