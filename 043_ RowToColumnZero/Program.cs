/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        You are given a 2D integer matrix A, 
        make all the elements in a row or column zero if the A[i][j] = 0. 
        Specifically, make entire ith row and jth column zero.

    Problem Constraints
    -------------------
        1 <= A.size() <= 10^3
        1 <= A[i].size() <= 10^3
        0 <= A[i][j] <= 10^3

    Output Format
    -------------
        Return an integer denoting the number of subarrays in A having sum less than B.

    Sample Input:
    ------------
        [1,2,3,4]
        [5,6,7,0]
        [9,2,0,4]

    Sample Output:
    -------------
        [1,2,0,0]
        [0,0,0,0]
        [0,0,0,0]

 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;

namespace _043__RowToColumnZero
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = new List<List<int>>
            {
                new List<int>{ 1,2,3,4 },
                new List<int>{ 5,6,7,0 },
                new List<int>{ 9,2,0,4 },
            };

            var result = SetRowColsToZero(inputA);

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

        static List<List<int>> SetRowColsToZero(List<List<int>> A)
        {
            int rows = A.Count;
            int cols = A[0].Count;

            var rowsArr = new List<int>(); 
            var colsArr = new List<int>();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (A[i][j] == 0)
                    {
                        if (!colsArr.Contains(j)) colsArr.Add(j);
                        if (!rowsArr.Contains(i)) rowsArr.Add(i);
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (colsArr.Contains(j) || rowsArr.Contains(i)) A[i][j] = 0;
                }
            }

            return A;
        }
    }
}
