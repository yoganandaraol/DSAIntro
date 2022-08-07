/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        You are given a matrix A, you have to return another matrix which is the transpose of A.
        NOTE: Transpose of a matrix A is defined as - AT[i][j] = A[j][i] ; Where 1 ≤ i ≤ col and 1 ≤ j ≤ row

    Problem Constraints
    -------------------
        1 <= A.size() <= 1000
        1 <= A[i].size() <= 1000
        1 <= A[i][j] <= 1000

    Output Format
    -------------
        Return an integer denoting the number of subarrays in A having sum less than B.

    Sample Input:
    ------------
         A = [[1, 2, 3],[4, 5, 6],[7, 8, 9]]

    Sample Output:
    -------------
        [
            [1, 4, 7], 
            [2, 5, 8], 
            [3, 6, 9]
        ]

    Sample Input:
    ------------
         A = [[1, 2],[1, 2],[1, 2]]

    Sample Output:
    -------------
        [
            [1, 1, 1], 
            [2, 2, 2]
        ]
 * 
 * ####################################################################
 */


using System;
using System.Collections.Generic;

namespace _041_MatrixTranspose
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
            //    new List<int>{ 1, 2 },
            //    new List<int>{ 1, 2 }
            //};

            var result = TransposeMarix(inputA);

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

        static List<List<int>> TransposeMarix(List<List<int>> A)
        {
            var rows = A.Count;
            var cols = A[0].Count;
            var result = new List<List<int>>();
            for (int i = 0; i < cols; i++)
            {
                var temp = new List<int>();
                for (int j = 0; j < rows; j++)
                {
                    temp.Add(A[j][i]);
                }
                result.Add(temp);
            }
            return result;
        }
    }
}
