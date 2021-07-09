using System;
using System.Collections.Generic;
using System.Linq;

namespace CrosswordPuzzle
{
    public static class Program
    {
        static void Main(string[] args)
        {
            char[][] matrix = new char[10][];
            for (int x = 0; x < 10; x++)
                matrix[x] = Console.ReadLine().ToCharArray();

            List<string> words = Console.ReadLine().Split(';').ToList();

            //Place the words where the - is

            PlaceFromLeftToRight(matrix, words);

            PrintMatrix(matrix);
            Console.WriteLine(new string('#', 15));

            PlaceFromUpperToLower(matrix, words);
        }

        static void PlaceFromLeftToRight(char[][] matrix, List<string> words)
        {
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                string mat = new string(matrix[x]);

                int startOfIndex = mat.IndexOf('-');
                if (startOfIndex == -1)
                    continue;
                int endOfIndex = mat.IndexOf('+', startOfIndex);
                int length = endOfIndex - startOfIndex;

                foreach (var word in words)
                {
                    if (word.Length == length)
                    {
                        for (int y = 0; y < word.Length; y++)
                            matrix[x][startOfIndex + y] = word[y];

                        word.Remove(words.IndexOf(word));
                        break;
                    }
                }
            }
        }

        static void PlaceFromUpperToLower(char[][] matrix, List<string> words)
        {
            List<int[]> indeciesXY = new List<int[]>();

            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(0); y++)
                    if (matrix[x][y] == '-')
                        indeciesXY.Add(new int[2] { x, y });
            }

            foreach (var word in words)
            {
                indeciesXY.ForEach(x => Console.WriteLine($"{x[0]} - {x[1]}"));
            }
        }

        static void PrintMatrix(char[][] matrix)
        {
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(0); y++)
                {
                    Console.Write(matrix[x][y]);
                }
                Console.Write("\n");
            }
        }
    }
}
