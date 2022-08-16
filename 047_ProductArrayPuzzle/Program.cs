/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Given an array of integers A, find and return the product array of the same size where 
        the ith element of the product array will be equal to the product of all the elements divided by the ith element of the array.

        Note: 
            It is always possible to form the product array with integer (32 bit) values. 
            Solve it without using the division operator.


    Problem Constraints
    -------------------
        2 <= length of the array <= 1000
        1 <= A[i] <= 10

    Output Format
    -------------
        Return the 2D rotated matrix.

    Sample Input:
    ------------
        A = [1, 2, 3, 4, 5]

    Sample Output:
    ------------
        [120, 60, 40, 30, 24]

    Sample Input:
    ------------
        A = [5, 1, 10, 1]

    Sample Output:
    ------------
        [10, 50, 5, 50]
 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace _047_ProductArrayPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(Enumerable.SequenceEqual(ProductArray(inputA), new List<int> { 120, 60, 40, 30, 24 }) ? "Passed" : "Failed");

            inputA = new List<int> { 5, 1, 10, 1 };
            Console.WriteLine(Enumerable.SequenceEqual(ProductArray(inputA), new List<int> { 10, 50, 5, 50 }) ? "Passed" : "Failed");
            
        }

        static List<int> ProductArray(List<int> A)
        {
            var prefixProduct = new List<int>(A);
            var suffixProduct = new List<int>(A);
            for (int i = 1; i < A.Count; i++)
            {
                prefixProduct[i] *= prefixProduct[i - 1];
                suffixProduct[A.Count - i - 1] *= suffixProduct[A.Count - i];
            }
            for (int i = 0; i < A.Count; i++)
            {
                if (i == 0) 
                    A[i] = suffixProduct[i + 1];
                else if (i == A.Count -1 ) 
                    A[i] = prefixProduct[i - 1];
                else 
                    A[i] = prefixProduct[i - 1] * suffixProduct[i + 1];
            }
            return A;
        }
    }
}
