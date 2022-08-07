/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        You are given a n x n 2D matrix.
        Rotate the matrix by 90 degrees (clockwise).

        Note: If you end up using an additional array, you will only receive partial score.

    Problem Constraints
    -------------------
        1 <= n <= 1000

    Output Format
    -------------
        Return the 2D rotated matrix.

    Sample Input:
    ------------
         [
            [1, 2],
            [3, 4]
         ]

    Sample Output:
    -------------
        [
            [3, 1],
            [4, 2]
        ]

    Sample Input:
    ------------
         [
            [1]
         ]

    Sample Output:
    -------------
        [
            [1]
        ]
      4
 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;

namespace _042_RotateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = new List<List<int>>
            {
                new List<int>{ 1, 2, 3 },
                new List<int>{ 4, 5, 6 },
                new List<int>{ 7, 8, 9 },
            };

            //var inputA = new List<List<int>>
            //{
            //    new List<int>{ 1, 2 },
            //    new List<int>{ 3, 4 },
            //};


            var result = RotateSquareMatix(inputA);

            for (int i = 0; i < result.Count; i++)
            {
                for (int j = 0; j < result[i].Count; j++)
                {
                    Console.Write(result[i][j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static List<List<int>> RotateSquareMatix(List<List<int>> A)
        {
            if (A.Count > 1)
            {
                for (int i = 0; i < A.Count; i++)
                {
                    for (int j = i + 1; j < A[i].Count; j++)
                    {
                        var temp = A[i][j];
                        A[i][j] = A[j][i];
                        A[j][i] = temp;
                    }
                }

                for (int i = 0; i < A.Count; i++)
                {
                    for (int j = 0 / 2; j < A.Count / 2; j++)
                    {
                        var temp = A[i][j];
                        A[i][j] = A[i][A.Count - j - 1];
                        A[i][A.Count - j - 1] = temp;
                    }
                }
            }

            return A;
        }
    }
}
