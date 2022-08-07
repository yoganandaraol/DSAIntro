/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        You are given a 2D integer matrix A, 
        return a 1D integer vector containing column-wise sums of original matrix.

    Problem Constraints
    -------------------
        1 <= A.size() <= 10^3
        1 <= A[i].size() <= 10^3
        1 <= A[i][j] <= 10^3

    Output Format
    -------------
        Return a vector conatining column-wise sums of original matrix.

    Sample Input:
    ------------
        [1,2,3,4]
        [5,6,7,8]
        [9,2,3,4]

    Sample Output:
    -------------
        [15,10,13,16]

 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;

namespace _039_ColumnSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = new List<List<int>> // Ans - {12, 15, 18}
            {
                new List<int>{ 1, 2, 3},
                new List<int>{ 4, 5, 6},
                new List<int>{ 7, 8, 9},
            };

            //var inputA = new List<List<int>> // Ans - {15,10,13,16}
            //{
            //    new List<int>{ 1,2,3,4},
            //    new List<int>{ 5,6,7,8},
            //    new List<int>{ 9,2,3,4},
            //};

            var result = MatColSum(inputA);

            foreach (var item in result)
            {
                Console.Write(item);
                Console.Write(" ");
            }
        }

        static List<int> MatColSum(List<List<int>> A)
        {
            var lstColSum = new List<int>();
            int rows = A.Count;
            int cols = A[0].Count;

            for (int i = 0; i < cols; i++)
            {
                int colSum = 0;
                for (int j = 0; j < rows; j++)
                {
                    colSum += A[j][i];
                }
                lstColSum.Add(colSum);

            }
            return lstColSum;
        }
    }
}
