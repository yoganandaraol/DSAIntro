/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Given an array A of N non-negative numbers and a non-negative number B,
        you need to find the number of subarrays in A with a sum less than B.
        We may assume that there is no overflow.

    Problem Constraints
    -------------------
        1 <= N <= 1000
        1 <= A[i] <= 1000
        1 <= B <= 10^7

    Output Format
    -------------
        Return an integer denoting the number of subarrays in A having sum less than B.

    Sample Input:
    ------------
         A = [2, 5, 6]
         B = 10

    Sample Output:
    -------------
        4

    Sample Input:
    ------------
         A = [1, 11, 2, 3, 15]
         B = 10

    Sample Output:
    -------------
        4
 * 
 * ####################################################################
 */


using System;
using System.Collections.Generic;

namespace _035_SumSubArraysLessLimit
{
    class Program
    {
        static void Main(string[] args)
        {
            //var inputA = new List<int> { 2, 5, 6 };
            //var inputLimit = 10;

            var inputA = new List<int> { 1, 11, 2, 3, 15 };
            var inputLimit = 10;

            Console.WriteLine(SubArraySumLessthanLimit(inputA, inputLimit));
        }

        static int SubArraySumLessthanLimit(List<int> A, int limit)
        {
            int count = 0;

            for (int i = 0; i < A.Count; i++)
            {
                int subTotal = 0;
                for (int j = i; j < A.Count; j++)
                {
                    subTotal += A[j];
                    if (subTotal < limit)
                        count++;
                }
            }
            return count;
        }
    }
}
