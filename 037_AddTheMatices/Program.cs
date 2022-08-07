/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        You are given two matrices A & B of same size, 
        you have to return another matrix which is the sum of A and B.

    Problem Constraints
    -------------------
        1 <= A.size(), B.size() <= 1000
        1 <= A[i].size(), B[i].size() <= 1000
        1 <= A[i][j], B[i][j] <= 1000

    Output Format
    -------------
        You have to return a vector of vector of integers after doing required operations.


    Sample Input:
    ------------
        A = [[1, 2, 3],[4, 5, 6],[7, 8, 9]]
        B = [[9, 8, 7],[6, 5, 4],[3, 2, 1]]

    Sample Output:
    -------------
        [[10, 10, 10], [10, 10, 10], [10, 10, 10]]

    
 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;

namespace _037_AddTheMatices
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = new List<List<int>>
            {
                new List<int>{ 1, 2, 3},
                new List<int>{ 4, 5, 6},
                new List<int>{ 7, 8, 9},
            };

            var inputB = new List<List<int>>
            {
                new List<int>{ 9, 8, 7},
                new List<int>{ 6, 5, 4},
                new List<int>{ 3, 2, 1},
            };

            var result = AddTwoMatrices(inputA, inputB);

            for (int i = 0; i < result.Count; i++)
            {
                for (int j = 0; j < result[i].Count; j++)
                {
                    Console.WriteLine(result[i][j]);
                }
            }
        }

        static List<List<int>> AddTwoMatrices(List<List<int>> A, List<List<int>> B)
        {
            var result = new List<List<int>>(A);
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < A[i].Count; j++)
                {
                    result[i][j] = A[i][j] + B[i][j];
                }
            }
            return result;
        }
    }
}
