/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Given an array of integers A, of size N.

        Return the maximum size subarray of A having only non-negative elements. 
        If there are more than one such subarray, return the one having the smallest starting index in A.

        NOTE: 
            It is guaranteed that an answer always exists.

    Problem Constraints
    -------------------
        1 <= N <= 10^5
        -10^9 <= A[i] <= 10^9

    Output Format
    -------------
        Return maximum size subarray of A having only non-negative elements. 
        If there are more than one such subarrays, return the one having earliest starting index in A.

    Sample Input:
    ------------
        A = [5, 6, -1, 7, 8]

    Sample Output:
    -------------
        [5, 6]

        Explanation:
            There are two subarrays of size 2 having only non-negative elements.
            1. [5, 6]  starting point  = 0
            2. [7, 8]  starting point  = 3
            As starting point of 1 is smaller, return [5, 6]

    Sample Input:
    ------------
        A = [1, 2, 3, 4, 5, 6]

    Sample Output:
    -------------
        [1, 2, 3, 4, 5, 6]
        
        Explanation:
            There is only one subarray of size 6 having only non-negative elements:
            [1, 2, 3, 4, 5, 6]
 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace _049_MaximumPositivity
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = new List<int> { 5, 6, -1, 7, 8 };
            Console.WriteLine(Enumerable.SequenceEqual(MaximumPositiveSubArray(inputA), new List<int> { 5, 6 }) ? "Passed" : "Failed");

            inputA = new List<int> { 5, 6, -1, 7, 8, 9 };
            Console.WriteLine(Enumerable.SequenceEqual(MaximumPositiveSubArray(inputA), new List<int> { 7, 8, 9 }) ? "Passed" : "Failed");

            inputA = new List<int> { 5, 6, 1, 7, 8, 9, -6 };
            Console.WriteLine(Enumerable.SequenceEqual(MaximumPositiveSubArray(inputA), new List<int> { 5, 6, 1, 7, 8, 9 }) ? "Passed" : "Failed");

            inputA = new List<int> { -6, 5, 6, 1, 7, 8, 9, -6 };
            Console.WriteLine(Enumerable.SequenceEqual(MaximumPositiveSubArray(inputA), new List<int> { 5, 6, 1, 7, 8, 9 }) ? "Passed" : "Failed");

            inputA = new List<int> { -6, 5, 6, 1, 7, 8, 9 };
            Console.WriteLine(Enumerable.SequenceEqual(MaximumPositiveSubArray(inputA), new List<int> { 5, 6, 1, 7, 8, 9 }) ? "Passed" : "Failed");


            inputA = new List<int> { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(Enumerable.SequenceEqual(MaximumPositiveSubArray(inputA), new List<int> { 1, 2, 3, 4, 5, 6 }) ? "Passed" : "Failed");

        }

        static List<int> MaximumPositiveSubArray(List<int> A)
        {
            var result = new List<int>();
            var countPosEle = 0;
            var countNegEle = 0;

            int maxArrSize = 0;
            int minIndex = int.MaxValue;
            for (int i = 0; i < A.Count; i++)
            {
                int leftArrSize = 0;
                int rightArrSize = 0;
                if (A[i] < 0)
                {
                    countNegEle++;
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (A[j] < 0) break;
                        leftArrSize++;
                    }
                    minIndex = leftArrSize > maxArrSize ? i - leftArrSize : minIndex;
                    maxArrSize = Math.Max(maxArrSize, leftArrSize);

                    for (int j = i + 1; j < A.Count; j++)
                    {
                        if (A[j] < 0) break;
                        rightArrSize++;
                    }
                    //minIndex = rightArrSize == leftArrSize ? minIndex : rightArrSize > maxArrSize ? i + 1 : minIndex;
                    minIndex = rightArrSize > maxArrSize ? i + 1 : minIndex;
                    maxArrSize = Math.Max(maxArrSize, rightArrSize);
                }
                else countPosEle++;
            }

            if (countPosEle == A.Count) return A;

            // This scenario never arises, because of the condition in problem
            //       "It is guaranteed that an answer always exists."
            if (countNegEle == A.Count) return new List<int>();

            for (int i = minIndex; i < minIndex+maxArrSize; i++)
            {
                result.Add(A[i]);
            }

            return result;
        }
    }
}
