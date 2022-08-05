/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
    Given an array of integers A, a subarray of an array is said to be good if it fulfills any one of the criteria:
        1. Length of the subarray is be even, and the sum of all the elements of the subarray must be less than B.
        2. Length of the subarray is be odd, and the sum of all the elements of the subarray must be greater than B.
    Your task is to find the count of good subarrays in A.

    Problem Constraints
    -------------------
        1 <= len(A) <= 10^3
        1 <= A[i] <= 10^3
        1 <= B <= 10^7


    Sample Input:
    ------------
        A = [1, 2, 3, 4, 5]
        B = 4

    Sample Output:
    -------------
        6

    Sample Input:
    ------------
        A = [13, 16, 16, 15, 9, 16, 2, 7, 6, 17, 3, 9]
        B = 65

    Sample Output:
    -------------
        36
 * 
 * ####################################################################
 */


using System;
using System.Collections.Generic;

namespace _034_CountGoodSubArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //var inputA = new List<int> { 1, 2, 3, 4, 5 };
            //var inputLimit = 4;

            var inputA = new List<int> { 13, 16, 16, 15, 9, 16, 2, 7, 6, 17, 3, 9 };
            var inputLimit = 65;

            Console.WriteLine(GoodSubArrays(inputA, inputLimit));
        }

        static int GoodSubArrays(List<int> A, int limit)
        {
            int count = 0;
            for (int i = 0; i < A.Count; i++)
            {
                int subTotal = 0;
                int subArraySize = 0;
                for (int j = i; j < A.Count; j++)
                {
                    subArraySize++;
                    subTotal += A[j];
                    if (subArraySize % 2 == 0 && subTotal < limit)
                        count++;
                    else if (subArraySize % 2 == 1 && subTotal > limit)
                        count++;
                }
            }
            return count;

        }
    }
}
