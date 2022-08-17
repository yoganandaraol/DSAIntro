/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Given an array A of integers. 
        You have to find the largest subarray length with contiguous elements and the array A may contain duplicate elements.

    Problem Constraints
    -------------------
        1 <= length of A <= 500
        1 <= A[i] <= 10^9

    Output Format
    -------------
        The length of longest subarray with contiguous elements

    Sample Input:
    ------------
        A = [4, 6, 2, 4, 1, 3, 9]

    Sample Output:
    -------------
        4
        Explanation:
            Subarray [2, 4, 1, 3] can be arranged to contiguous elements sequence 
            [1, 2, 3, 4] and has a length equal to 4, which is the largest subarray 
            with contiguous elements. 

    Sample Input:
    ------------
        A = [8, 8, 10, 11, 9, 13]

    Sample Output:
    -------------
        4
        Explanation:
            Subarray [8, 10, 11, 9] can be arranged to contiguous elements sequence 
            [8, 9, 10, 11] and has a length equal to 4, which is the largest subarray 
            with contiguous elements. 
 * 
 *  Solution Approach:
 *  ------------------
 *      Sum of n consecutive/contigious numbers is n * (max + min)/2 should be equal to sum of sub array elements
 *      if above condition is valid -- means that is the possible 
 *      
 * 
 * 
 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;

namespace _050_LargestSubarrayWithContiguousElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = new List<int> { 4, 6, 2, 4, 1, 3, 9 };
            Console.WriteLine(LargestSubarrayWithContiguousElements(inputA) == 4 ? "Passed" : "Failed");

            inputA = new List<int> { 8, 8, 10, 11, 9, 13 };
            Console.WriteLine(LargestSubarrayWithContiguousElements(inputA) == 4 ? "Passed" : "Failed");

            inputA = new List<int> { 1, 2, 3, 4, 6, 5, 9, 11, 8, 10, 7 };
            Console.WriteLine(LargestSubarrayWithContiguousElements(inputA) == 11 ? "Passed" : "Failed");

            inputA = new List<int> { 1, 2, 3, 4, 6, 5, 9, 11, 8, 6, 7 };
            Console.WriteLine(LargestSubarrayWithContiguousElements(inputA) == 6 ? "Passed" : "Failed");

            inputA = new List<int> { 1, 2, 3, 4, 6, 5, 9, 11, 8, 10, 7, 0, -3, -1, -2 };
            Console.WriteLine(LargestSubarrayWithContiguousElements(inputA) == 15 ? "Passed" : "Failed");

            inputA = new List<int> { 1, 2, 2, 5, 5 };
            Console.WriteLine(LargestSubarrayWithContiguousElements(inputA) == 2 ? "Passed" : "Failed");
            
        }

        static int LargestSubarrayWithContiguousElements(List<int> A)
        {
            int largestArrSize = 0;

            for (int i = 0; i < A.Count; i++)
            {
                int min = int.MaxValue; 
                long max = long.MinValue;
                long subArraySum = 0;
                var subArray = new HashSet<int>();
                for (int j = i; j < A.Count; j++)
                {
                    subArray.Add(A[j]);
                    subArraySum += A[j];
                    min = Math.Min(min, A[j]);
                    max = Math.Max(max, A[j]);

                    if ((max + min) * (max - min + 1) / 2 == subArraySum && subArray.Count == max - min + 1)
                    {
                        largestArrSize = Math.Max(largestArrSize, j - i + 1);
                    }
                }
            }
            return largestArrSize;
        }

        static int LargestSubarrayWithContiguousElementsV1(List<int> A)
        {
            int largestArrSize = 0;
            var prefixSum = new List<int>(A);
            for (int i = 1; i < A.Count; i++)
            {
                prefixSum[i] += prefixSum[i - 1];
            }
            //TODO
            for (int i = 0; i < A.Count; i++)
            {
                int min = int.MaxValue, max = int.MinValue;
                long subArraySum = 0;
                for (int j = i; j < A.Count; j++)
                {
                    if (j == 0) subArraySum = prefixSum[j];
                    else subArraySum = prefixSum[j] - prefixSum[i];

                    min = Math.Min(min, A[j]);
                    max = Math.Max(max, A[j]);

                    if ((max + min) * (max - min + 1) / 2 == subArraySum)
                    {
                        largestArrSize = Math.Max(largestArrSize, j - i + 1);
                    }
                }
            }
            return largestArrSize;
        }

    }
}
