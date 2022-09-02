/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        You are given an array of N integers, A1, A2 ,..., AN and an integer B. 
        Return the of count of distinct numbers in all windows of size B.

        Formally, return an array of size N-B+1 where i'th element in this array contains number of distinct elements in sequence Ai, Ai+1 ,..., Ai+B-1.

        NOTE: 
            if B > N, return an empty array.

    Problem Constraints
    -------------------
        --

    Input Format
    -------------
        First argument is an integer array A
        Second argument is an integer B.

    Output Format
    -------------
        Return an integer array.

    Sample Input:
    ------------
        A = [1, 2, 1, 3, 4, 3]
        B = 3

    Sample Output:
    -------------
        [2, 3, 3, 2]

        Explanation:
            A=[1, 2, 1, 3, 4, 3] and B = 3
            All windows of size B are
            [1, 2, 1]
            [2, 1, 3]
            [1, 3, 4]
            [3, 4, 3]
            So, we return an array [2, 3, 3, 2].

    Sample Input:
    ------------
        A = [1, 1, 2, 2]
        B = 1

    Sample Output:
    -------------
        [1, 1, 1, 1]
        
        Explanation:
            Window size is 1, so the output array is [1, 1, 1, 1].
 * 
 * ####################################################################
 */


using System;
using System.Collections.Generic;
using System.Linq;

namespace _096_DistinctNumbersInWindow
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputA = new List<int> { 1, 2, 1, 3, 4, 3 };
            List<int> output = new List<int> { 2, 3, 3, 2 };
            Console.WriteLine(Enumerable.SequenceEqual(DistinctNumbersV1(inputA, 3), output) ? "Passed" : "Failed");

            inputA = new List<int> { 1, 1, 2, 2 };
            output = new List<int> { 1, 1, 1, 1 };
            Console.WriteLine(Enumerable.SequenceEqual(DistinctNumbersV1(inputA, 1), output) ? "Passed" : "Failed");

        }

        // Bruteforce Approach
        // TC = O((N-B+1)*B) ~ O(N*B)
        // SC = O(N)
        static List<int> DistinctNumbers(List<int> A, int B)
        {
            if (A.Count < B) return new List<int>();

            var result = new List<int>();

            for (int i = 0; i + B <= A.Count; i++)
            {
                Dictionary<int, int> distCount = new Dictionary<int, int>();
                for (int j = i; j < i + B; j++)
                {
                    if (distCount.ContainsKey(A[j]))
                        distCount[A[j]] += 1;
                    else
                        distCount.Add(A[j], 1);
                }
                result.Add(distCount.Count);
            }

            return result;
        }

        // Sliding window approach
        // TC = O(N)
        // SC = O(N)
        static List<int> DistinctNumbersV1(List<int> A, int B)
        {
            if (A.Count < B) return new List<int>();

            var result = new List<int>();
            Dictionary<int, int> distCount = new Dictionary<int, int>();

            int sSize = 0;
            for (int i = 0; i < A.Count; i++)
            {
                sSize++;

                if (distCount.ContainsKey(A[i]))
                    distCount[A[i]] += 1;
                else
                    distCount.Add(A[i], 1);

                if (sSize == B)
                {
                    result.Add(distCount.Count);
                    sSize--;

                    int prevIndex = (i + 1) - B;
                    if (distCount.ContainsKey(A[prevIndex]))
                    {
                        if (distCount[A[prevIndex]] > 1)
                            distCount[A[prevIndex]] -= 1;
                        else
                            distCount.Remove(A[prevIndex]);
                    }
                }
                
            }

            return result;
        }
    }
}
