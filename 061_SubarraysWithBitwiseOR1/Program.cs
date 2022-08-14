/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Given an array B of length A with elements 1 or 0. Find the number of subarrays with bitwise OR 1.

    Problem Constraints
    -------------------
        1 <= A <= 10^5

    Output Format
    -------------
        Return the number of subarrays with bitwise array 1.

    Sample Input:
    ------------
        A = 3
        B = [1, 0, 1]

    Sample Output:
    -------------
        5
        Explanation:
            The subarrays are :- [1], [0], [1], [1, 0], [0, 1], [1, 0, 1]
            Except the subarray [0] all the other subarrays has a Bitwise OR = 1


    Sample Input:
    ------------
        A = 2
        B = [1, 0]

    Sample Output:
    -------------
        2
        Explanation:
            The subarrays are :- [1], [0], [1, 0]
            Except the subarray [0] all the other subarrays has a Bitwise OR = 1
 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;

namespace _061_SubarraysWithBitwiseOR1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputB = new List<int> { 1, 0, 1 };
            Console.WriteLine(SubArraysHavingBitwiseOR1V1(3, inputB) == 5 ? "Passed" : "Failed");
            inputB = new List<int> { 1, 0 };
            Console.WriteLine(SubArraysHavingBitwiseOR1V1(2, inputB) == 2 ? "Passed" : "Failed");
            inputB = new List<int> { 1, 0, 1, 1, 1, 0, 0 };
            Console.WriteLine(SubArraysHavingBitwiseOR1V1(7, inputB) == 24 ? "Passed" : "Failed");
        }

        static long SubArraysHavingBitwiseOR1(int A, List<int> B)
        {
            long countSubArrysHaving1 = 0;
            for (int i = 0; i < B.Count; i++)
            {
                int subArraySum = 0;
                for (int j = i; j < B.Count; j++)
                {
                    subArraySum += B[j];
                    if (subArraySum > 0) countSubArrysHaving1++;
                }
            }
            return countSubArrysHaving1;
        }

        static long SubArraysHavingBitwiseOR1V1(int A, List<int> B)
        {
            long count = 0;
            long last = 0;

            for (int i = 0; i < A; i++)
            {
                if (B[i] == 1)
                {
                    last = i + 1;
                }
                count += last;

            }
            return count;
        }
    }
}
