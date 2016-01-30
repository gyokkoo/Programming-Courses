namespace RotingWalkInMatrix.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using RotatingWalkInMatrix;

    [TestClass]
    public class RotatingWalkInMatrixTests
    {
        [TestMethod]
        public void TestGenerateMatrix_Size1()
        {
            int[,] matrix = WalkInMatrix.GenerateMatrix(6);

            int[,] expectedMatrix = { { 1 } };

            for (int row = 0; row < expectedMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < expectedMatrix.GetLength(1); col++)
                {
                    Assert.AreEqual(matrix[row, col], expectedMatrix[row, col]);
                }
            }
        }

        [TestMethod]
        public void TestGenerateMatrix_Size2()
        {
            int[,] matrix = WalkInMatrix.GenerateMatrix(2);

            int[,] expectedMatrix = { { 1, 4 }, { 3, 2 } };

            for (int row = 0; row < expectedMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < expectedMatrix.GetLength(1); col++)
                {
                    Assert.AreEqual(matrix[row, col], expectedMatrix[row, col]);
                }
            }
        }

        [TestMethod]
        public void TestGenerateMatrix_Size3()
        {
            int[,] matrix = WalkInMatrix.GenerateMatrix(3);

            int[,] expectedMatrix =
                {
                    { 1, 7, 8 },
                    { 6, 2, 9 },
                    { 5, 4, 3 }
                };
        }

        [TestMethod]
        public void TestGenerateMatrix_Size6()
        {
            int[,] matrix = WalkInMatrix.GenerateMatrix(6);

            int[,] expectedMatrix =
                {
                    { 1, 16, 17, 18, 19, 20 }, { 15, 2, 27, 28, 29, 21 }, { 14, 31, 3, 26, 30, 22 },
                    { 13, 36, 32, 4, 25, 23 }, { 12, 35, 34, 33, 5, 24 }, { 11, 10, 9, 8, 7, 6 }
                };

            for (int row = 0; row < expectedMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < expectedMatrix.GetLength(1); col++)
                {
                    Assert.AreEqual(matrix[row, col], expectedMatrix[row, col]);
                }
            }
        }
    }
}