/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        You are given two integer matrices A and B having same size
        (
            Both having same number of rows (N) and columns (M)). 
            You have to subtract matrix A from B and return the resultant matrix. 
            (i.e. return the matrix A - B)
        ).

        If X and Y are two matrices of the same order (same dimensions). 
        Then X - Y is a matrix of the same order as X and Y and its elements are obtained by subtracting the elements of Y from the corresponding elements of X. Thus if Z = [z[i][j]] = X - Y, then [z[i][j]] = [x[i][j]] – [y[i][j]].

    Problem Constraints
    -------------------
        1 <= N, M <= 10^3
        -10^9 <= A[i][j], B[i][j] <= 10^9

    
    Sample Input:
    ------------
          A = [ [1, 2, 3],            B = [ [9, 8, 7],
                [4, 5, 6],                  [6, 5, 4],
                [7, 8, 9] ]                 [3, 2, 1] ]

    Sample Output:
    -------------
        [ [-8, -6, -4],
          [-2,  0,  2],
          [ 4,  6,  8] ]

    
 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;

namespace _040_MatrixSubstraction
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

            var result = MatrixSubstraction(inputA, inputB);

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

        static List<List<int>> MatrixSubstraction(List<List<int>> A, List<List<int>> B)
        {
            var result = new List<List<int>>();
            // Size of Matrix A and B are same.. So
            int rows = A.Count;
            int cols = A[0].Count;

            for (int i = 0; i < rows; i++)
            {
                var temp = new List<int>();
                for (int j = 0; j < cols; j++)
                {
                    temp.Add(A[i][j] - B[i][j]);
                }
                result.Add(temp);
            }

            return result;
        }

    }
}
