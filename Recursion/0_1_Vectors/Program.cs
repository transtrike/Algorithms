using System;

namespace _0_1_Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] currentVector = new int[8][]
            { 
                new int[8] {0, 0, 0, 0, 0, 0, 0, 0},
                new int[8] {0, 0, 0, 0, 0, 0, 0, 0},
                new int[8] {0, 0, 0, 0, 0, 0, 0, 0},
                new int[8] {0, 0, 0, 0, 0, 0, 0, 0},
                new int[8] {0, 0, 0, 0, 0, 0, 0, 0},
                new int[8] {0, 0, 0, 0, 0, 0, 0, 0},
                new int[8] {0, 0, 0, 0, 0, 0, 0, 0},
                new int[8] {0, 0, 0, 0, 0, 0, 0, 0}
            };
            GenerateVector(currentVector);
            PrintVector(currentVector);
        }

        static void GenerateVector(int[][] vector, int x = 0, int y = 0)
        {
            if (x >= vector.GetLength(0) || y >= vector.GetLength(0))
            {
                return;
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    vector[x][y] = i;
                    GenerateVector(vector, x + i, y + 1);
                }

                for (int i = 0; i <= 1; i++)
                {
                    vector[x][y] = i;
                    GenerateVector(vector, x + 1, y + i);
                }
            }
        }

        static void PrintVector(int[][] vector)
        {
            for (int x = 0; x < vector.GetLength(0); x++)
            {
                for (int y = 0; y < vector.GetLength(0); y++)
                    Console.Write(vector[x][y]);

                Console.Write("\n");
            }
        }
    }
}
