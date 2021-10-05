using System;

namespace Weekly_Coding_10_04
{
    class Program
    {
        static bool CannotCapture(int[,] grid)
        {
            bool result = true;
            int height = grid.GetLength(0);
            int width = grid.GetLength(1);
            for (int x = 0; result && x < height - 1; x++)
            {
                for (int y = 0; result && y < width; y++)
                {
                    if (grid[x,y] == 1)
                    {
                        if (x + 2 < height)
                        {
                            if (y + 1 < width)
                                result = grid[x + 2, y + 1] == 0;
                            if (result && y - 1 >= 0)
                                result = grid[x + 2, y - 1] == 0;
                        }
                        if (result)
                        {
                            if (y + 2 < width)
                                result = grid[x + 1, y + 2] == 0;
                            if (result && y - 2 >= 0)
                                result = grid[x + 1, y - 2] == 0;
                        }
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CannotCapture(new int[,] {
                { 0, 0, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 1, 0 },
                { 0, 1, 0, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 0, 0, 0, 0, 1 },
                { 0, 0, 0, 0, 1, 0, 0, 0 }
                }));

            Console.WriteLine(CannotCapture(new int[,] {
                {1, 0, 1, 0, 1, 0, 1, 0},
                {0, 1, 0, 1, 0, 1, 0, 1},
                {1, 0, 1, 0, 1, 0, 1, 0},
                {0, 0, 0, 1, 0, 1, 0, 1},
                {1, 0, 0, 0, 1, 0, 1, 0},
                {0, 0, 0, 0, 0, 1, 0, 1},
                {1, 0, 1, 0, 1, 0, 1, 0},
                {1, 0, 0, 1, 0, 0, 0, 1}
                }));
        }
    }
}
