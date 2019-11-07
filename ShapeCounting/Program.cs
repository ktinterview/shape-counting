using System;

namespace ShapeCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] sampleGrid =
                {
                { 1, 1, 1 },
                { 0, 1, 0 },
                { 0, 1, 0 }
            };

            Console.Write("The number of shapes in this grid is: ");
            Console.Write(ShapeCounter.CountShapes(sampleGrid));
        }
    }
}
