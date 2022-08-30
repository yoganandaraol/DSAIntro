/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Given two integer arrays, A and B of size N and M, respectively. 
        Your task is to find all the common elements in both the array.

        NOTE:
            Each element in the result should appear as many times as it appears in both arrays.
            The result can be in any order.

    Problem Constraints
    -------------------
        1 <= N, M <= 10^5
        1 <= A[i] <= 10^9

    Output Format
    -------------
        Return an integer array denoting the common elements.

    Sample Input:
    ------------
         A = [1, 2, 2, 1]
         B = [2, 3, 1, 2]

    Sample Output:
    -------------
        [1, 2, 2]

        Explanation:
            Elements (1, 2, 2) appears in both the array. Note 2 appears twice in both the array.

    Sample Input:
    ------------
        A = [2, 1, 4, 10]
        B = [3, 6, 2, 10, 10]

    Sample Output:
    -------------
        [2, 10]
        
        Explanation:
            Elements (2, 10) appears in both the array.
 * 
 * ####################################################################
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _089_CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputA = new List<int> { 1, 2, 2, 1 };
            List<int> inputB = new List<int> { 2, 3, 1, 2 };
            List<int> output = new List<int> { 1, 2, 2 };
            Console.WriteLine(Enumerable.SequenceEqual(FindCommonElementsV1(inputA, inputB), output) ? "Passed" : "Failed");

            inputA = new List<int> { 2, 1, 4, 10 };
            inputB = new List<int> { 3, 6, 2, 10, 10 };
            output = new List<int> { 2, 10 };
            Console.WriteLine(Enumerable.SequenceEqual(FindCommonElementsV1(inputA, inputB), output) ? "Passed" : "Failed");
        }

        static List<int> FindCommonElements(List<int> A, List<int> B)
        {
            Hashtable htA = new Hashtable();
            Hashtable htB = new Hashtable();
            List<int> result = new List<int>();

            for (int i = 0; i < A.Count; i++)
            {
                if (htA.Contains(A[i]))
                    htA[A[i]] = Convert.ToInt32(htA[A[i]]) + 1;
                else
                    htA.Add(A[i], 1);
            }

            for (int i = 0; i < B.Count; i++)
            {
                if (htB.Contains(B[i]))
                    htB[B[i]] = Convert.ToInt32(htB[B[i]]) + 1;
                else 
                    htB.Add(B[i], 1);
            }

            foreach (var item in A)
            {
                if (htA.Contains(item) && htB.Contains(item) && Convert.ToInt32(htA[item]) > 0 && Convert.ToInt32(htB[item]) > 0)
                {
                    result.Add(item);
                    if (htA.Contains(item))
                        htA[item] = Convert.ToInt32(htA[item]) - 1;
                    if (htB.Contains(item))
                        htB[item] = Convert.ToInt32(htB[item]) - 1;
                }
            }

            return result;
        }

        static List<int> FindCommonElementsV1(List<int> A, List<int> B)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < B.Count; i++)
            {
                if (dic.ContainsKey(B[i])) dic[B[i]]++;
                else dic.Add(B[i], 1);
            }
            List<int> result = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (dic.ContainsKey(A[i]) && dic[A[i]] > 0)
                {
                    result.Add(A[i]);
                    dic[A[i]]--;
                }
            }
            return result;
        }
    }
}
