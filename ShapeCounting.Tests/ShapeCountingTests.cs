using NUnit.Framework;

namespace ShapeCounting.Tests
{
    public class ShapeCountingTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void When_3x3GridWith2Shapes_Then_2Shapes()
        {
            int[,] sampleGrid =
                {
                { 1, 0, 1 },
                { 0, 0, 1 },
                { 0, 0, 1 }
            };

            int result = ShapeCounter.CountShapes(sampleGrid);

            Assert.IsTrue(result == 2);
        }

        [Test]
        public void When_1x1Grid_Then_1Shape()
        {
            int[,] sampleGrid =
                {
                { 1 },
                { 0 }
            };

            int result = ShapeCounter.CountShapes(sampleGrid);

            Assert.IsTrue(result == 1);
        }

        [Test]
        public void When_FullGrid_Then_1Shape()
        {
            int[,] sampleGrid =
                {
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 }
            };

            int result = ShapeCounter.CountShapes(sampleGrid);

            Assert.IsTrue(result == 1);
        }

        [Test]
        public void When_EmptyGrid_Then_0Shapes()
        {
            int[,] sampleGrid = { };

            int result = ShapeCounter.CountShapes(sampleGrid);

            Assert.IsTrue(result == 0);
        }

        [Test]
        public void When_Empty3x3Grid_Then_0Shapes()
        {
            int[,] sampleGrid =
                {
                { 0, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            };

            int result = ShapeCounter.CountShapes(sampleGrid);

            Assert.IsTrue(result == 0);
        }
    }
}