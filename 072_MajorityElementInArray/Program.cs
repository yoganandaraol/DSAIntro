/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Given an array of size N, find the majority element. The majority element is the element that appears more than floor(n/2) times.
        You may assume that the array is non-empty and the majority element always exists in the array.

    Problem Constraints
    -------------------
        1 <= N <= 5*10^5
        1 <= num[i] <= 10^9

    Output Format
    -------------
        Return an integer.

    Sample Input:
    ------------
        [2, 1, 2]

    Sample Output:
    -------------
        2

        Explanation:
            2 occurs 2 times which is greater than 3/2.

 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;

namespace _072_MajorityElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = new List<int> { 2, 1, 2 };
            Console.WriteLine(MajorityElement(inputA) == 2 ? "Passed" : "Failed");
            inputA = new List<int> { 4,6,5,3,4,5,6,4,4 };
            Console.WriteLine(MajorityElement(inputA) == -1 ? "Passed" : "Failed");
            inputA = new List<int> { 3,4,3,6,1,3,2,3,3,5,3 };
            Console.WriteLine(MajorityElement(inputA) == 3 ? "Passed" : "Failed");
        }

        static int MajorityElement(List<int> A)
        {
            int ans = A[0];
            int freq = 1;

            for (int i = 1; i < A.Count; i++)
            {
                if (freq == 0)
                {
                    ans = A[i];
                    freq = 1;
                }
                else if (A[i] == ans)
                {
                    freq++;
                    ans = A[i];
                }
                else
                    freq--;
            }

            int count = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] == ans)
                    count++;
            }
            return count > A.Count/2 ? ans : -1;
        }
    }
}
