using System;
namespace ShapeCounting
{
    public static class ShapeCounter
    {
        public static int CountShapes(int[,] grid)
        {
            if (grid == null || grid.Length == 0)
                return 0;

            int shapeCount = 0;
            for (int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid.GetLength(1); col++)
                {
                    //check if the cell was already looked at
                    if (grid[row, col] == 1)
                    {
                        LookAround(row, col, grid);
                        shapeCount++;
                    }
                }
            }

            return shapeCount;
        }

        private static void LookAround(int row, int col, int[,] grid)
        {
            //if went out of bounds of the grid, stop looking around
            if (row >= 0 && row < grid.GetLength(0) && col >= 0 && col < grid.GetLength(1))
            {
                //if we hit an empty or already looked at cell, stop
                if (grid[row, col] != 0)
                {
                    //first mark the cell we are on to "looked at"
                    grid[row, col] = 0;

                    //then look at all adjacent cells
                    LookAround(row, col + 1, grid);
                    LookAround(row, col - 1, grid);
                    LookAround(row + 1, col, grid);
                    LookAround(row - 1, col, grid);
                }
            }
        }
    }
}
