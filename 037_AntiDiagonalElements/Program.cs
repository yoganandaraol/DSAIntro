/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Give a N * N square matrix A, return an array of its anti-diagonals. 

    Problem Constraints
    -------------------
        1<= N <= 1000
        1<= A[i][j] <= 1e9

    Input Format
    ------------
        First argument is an integer N, denoting the size of square 2D matrix.
        Second argument is a 2D array A of size N * N.

    Output Format
    -------------
        Return a 2D integer array of size (2*N - 1) * N, representing the anti-diagonals of input array A.
        The vacant spaces in the grid should be assigned to 0.

    Sample Input:
    ------------
        1 2 3
        4 5 6
        7 8 9

    Sample Output:
    -------------
        1 0 0
        2 4 0
        3 5 7
        6 8 0
        9 0 0

    Sample Input:
    ------------
        1 2
        3 4

    Sample Output:
    -------------
        1 0
        2 3
        4 0
 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;

namespace _038_AntiDiagonalElements
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
            //var inputA = new List<List<int>>
            //{
            //    new List<int>{ 1, 2},
            //    new List<int>{ 3, 4}
            //};
            //var inputA = new List<List<int>>
            //{
            //    new List<int>{ 1 }
            //};
            var result = AntiDiagonal(inputA);
            foreach (var resultItem in result)
            {
                foreach (var item in resultItem)
                {
                    Console.Write(item);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static List<List<int>> AntiDiagonal(List<List<int>> A)
        {
            var result = new List<List<int>>();

            if (A.Count == 1)
            {
                return A;
            }
            for (int i = 0; i < A.Count; i++)
            {
                int resultRowIndex = 0;
                int resultColIndex = i;
                var temp = new List<int>();
                for (int j = 0; j < A[i].Count; j++)
                {
                    if (resultRowIndex >= A[i].Count || resultColIndex < 0)
                        temp.Add(0);
                    else
                        temp.Add(A[resultRowIndex][resultColIndex]);

                    resultRowIndex++;
                    resultColIndex--;
                }
                result.Add(temp);
            }

            for (int i = 1; i < A.Count; i++)
            {
                int resultRowIndex = i;
                int resultColIndex = A.Count - 1;
                var temp = new List<int>();
                for (int j = 0; j < A[i].Count; j++)
                {
                    if (resultRowIndex >= A[i].Count || resultColIndex < 0)
                        temp.Add(0);
                    else
                        temp.Add(A[resultRowIndex][resultColIndex]);

                    resultRowIndex++;
                    resultColIndex--;
                }
                result.Add(temp);
            }

            return result;
        }
    }
}
