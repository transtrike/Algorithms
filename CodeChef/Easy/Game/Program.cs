using System;

namespace Game
{
	class Program
	{
		static void Main(string[] args)
		{
			uint testCases = uint.Parse(Console.ReadLine());
			uint[] result = new uint[testCases];

			//For each test case
			for (int i = 0; i < testCases; i++)
			{
				uint arrayLength = uint.Parse(Console.ReadLine());
				string[] stringArray = Console.ReadLine().Split(' ');

				//Parser
				uint[] parsedArray = new uint[arrayLength];
				for (int t = 0; t < arrayLength; t++)
					parsedArray[i] = uint.Parse(stringArray[i]);

				//For each player
				for (uint p = 1; p < 3; p++)
				{
					//Calculate moves of P1
					uint biggestNumberIndex = 0;
					for (uint j = 0; j < parsedArray.Length; j++)
					{
						if (parsedArray[j] >= biggestNumberIndex)
							biggestNumberIndex = j;
					}

					if (parsedArray[biggestNumberIndex] >= p)
					{
						parsedArray[biggestNumberIndex] -= p;
						if (p == 1) result[i]++;
					}
				}
			}

			//Print result
			for (int i = 0; i < result.Length; i++)
				Console.WriteLine(result[i]);
		}
	}
}
