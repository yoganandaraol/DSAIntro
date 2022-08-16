/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Given an array of integers A, find and return the product array of the same size where the ith element of the product array will be equal to the product of all the elements divided by the ith element of the array.

        Note: 
            It is always possible to form the product array with integer (32 bit) values. 
            Solve it without using the division operator.

    Problem Constraints
    -------------------
        2 <= length of the array <= 1000
        1 <= A[i] <= 10

    Output Format
    -------------
        Return the product array.

    Sample Input:
    ------------
        A = [1, 2, 3, 4, 5]

    Sample Output:
    -------------
        [120, 60, 40, 30, 24]

    Sample Input:
    ------------
        A = [5, 1, 10, 1]

    Sample Output:
    -------------
        [10, 50, 5, 50]
 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;

namespace _048_CoutOfIncreasingTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = new List<int> { 1, 2, 4, 3 };
            Console.WriteLine(CoutOfIncreasingTriplets(inputA) == 2 ? "Passed" : "Failed");

            inputA = new List<int> { 2, 1, 2, 3 };
            Console.WriteLine(CoutOfIncreasingTriplets(inputA) == 1 ? "Passed" : "Failed");

            inputA = new List<int> { 6, 3, 11, 25 };
            Console.WriteLine(CoutOfIncreasingTriplets(inputA) == 2 ? "Passed" : "Failed");
        }
        static int CoutOfIncreasingTriplets(List<int> A)
        {
            int ans = 0;
            
            for (int i = 0; i < A.Count; i++)
            {
                int leftCount = 0;
                for (int j = 0; j < i; j++)
                    if (A[j] < A[i]) 
                        leftCount++;

                for (int j = i + 1; j < A.Count; j++)
                    if (A[i] < A[j] && leftCount > 0)
                        ans += leftCount;
            }
            return ans;
        }
    }
}
