namespace ConsoleApplication1
{
    using System;

    public class MatrixMultiplication
    {
        public static void Main()
        {
            double[,] firstMatrix = { { 1, 3 }, { 5, 7 } };
            double[,] secondMatrix = { { 4, 2 }, { 1, 5 } };

            var productMatrix = GetMultiplicatedMatrix(firstMatrix, secondMatrix);

            for (int row = 0; row < productMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < productMatrix.GetLength(1); col++)
                {
                    Console.Write(productMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static double[,] GetMultiplicatedMatrix(double[,] firstMatrix, double[,] secondMatrix)
        {
            if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
            {
                throw new InvalidOperationException("The matrixes dimensions do not match!");
            }

            int firstMatrixColumns = firstMatrix.GetLength(1);

            double[,] productMatrix = new double[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

            for (int row = 0; row < productMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < productMatrix.GetLength(1); col++)
                {
                    for (int index = 0; index < firstMatrixColumns; index++)
                    {
                        productMatrix[row, col] += firstMatrix[row, index] * secondMatrix[index, col];
                    }
                }
            }

            return productMatrix;
        }
    }
}