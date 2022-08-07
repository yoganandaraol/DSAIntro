using System;

namespace _036_DiagonalElementsRectMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] recMat = new int[3, 4]
            {
                { 0, 1, 2, 3 },
                { 4, 5, 6, 7 },
                { 8, 9, 10, 11 }
            };

            int row = 0;

            for (int col = 0; col < recMat.GetLength(1); col++)
            { 
                while (row < recMat.GetLength(0) && col >= 0)
                {
                    Console.WriteLine(recMat[row, col]);
                    row++;
                    col--;
                }
            }
        }
    }
}
