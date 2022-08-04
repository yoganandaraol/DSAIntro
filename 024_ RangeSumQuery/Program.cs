/*
 * Problem Description
        You are given an integer array A of length N.
        You are also given a 2D integer array B with dimensions M x 2, where each row denotes a [L, R] query.
        For each query, you have to find the sum of all elements from L to R indices in A (1 - indexed).
        More formally, find A[L] + A[L + 1] + A[L + 2] +... + A[R - 1] + A[R] for each query.

    Problem Constraints
        1 <= N, M <= 10^5
        1 <= A[i] <= 10^9
        1 <= L <= R <= N
 
 * Example Input
        Input 1:
            A = [1, 2, 3, 4, 5]
            B = [[1, 4], [2, 3]]
        Output 1:
            [10, 5]
        
        Input 2:
            A = [2, 2, 2]
            B = [[1, 1], [2, 3]]
        Output 2:
            [2, 4]
            
 */


using System;
using System.Collections.Generic;

namespace _024_RangeSumQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Test Case 1

            //var input1 = new List<int> { 1, 2, 3, 4, 5 };
            //var input2 = new List<List<int>> { new List<int> { 1, 4 }, new List<int> { 2, 3 } };

            #endregion
            #region Test Case 2

            var input1 = new List<int> { 2, 2, 2 };
            var input2 = new List<List<int>> { new List<int> { 1, 1 }, new List<int> { 2, 3 } };

            #endregion
            #region Test Case 3

            //var input1 = new List<int> { 4, 5, 6, 9, 4, 1, 8, 3 };
            //var input2 = new List<List<int>>
            //{
            //    new List<int>{2, 4},
            //    new List<int>{7, 8},
            //    new List<int>{1, 4},
            //    new List<int>{1, 6},
            //    new List<int>{8, 8},
            //    new List<int>{2, 2},
            //    new List<int>{4, 8},
            //    new List<int>{2, 4},
            //    new List<int>{7, 8},
            //    new List<int>{6, 7}
            //};

            #endregion
            #region Test Case 4
            //var input1 = new List<int> { 7, 3, 1, 5, 5, 5, 1, 2, 4, 5 };
            //var input2 = new List<List<int>>
            //{
            //    new List<int>{7, 10},
            //    new List<int>{3, 10},
            //    new List<int>{3, 5},
            //    new List<int>{1, 10}
            //};
            //// Expected Output 12 28 11 38 
            #endregion

            var result = RangeSumV1(input1, input2);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static List<long> RangeSum(List<int> A, List<List<int>> B)
        {
            var result = new List<long>();

            var prefixSum = new List<int>(A); // SC = O(N)
            for (int i = 1; i < A.Count; i++) // TC = O(N)
            {
                prefixSum[i] = prefixSum[i - 1] + A[i];
            }

            foreach (var item in B) // TC = O(Q) & SC = O(1)   | Q = B.Count
            {
                int fromIndex = item[0] > A.Count ? (item[0] % A.Count) - 1 : item[0] - 1;
                int toIndex = item[1] > A.Count ? (item[1] % A.Count) - 1 : item[1] - 1;

                if (fromIndex == toIndex)
                    result.Add(A[toIndex]);
                else
                {
                    if (fromIndex == 0)
                        result.Add(prefixSum[toIndex]);
                    else
                        result.Add(prefixSum[toIndex] - prefixSum[fromIndex - 1]);
                }
            }
            return result;
        }

        static List<long> RangeSumV1(List<int> A, List<List<int>> B)
        {
            var result = new List<long>();
            var prefixSum = new List<long> { A[0] }; // For too large values of A[i] need prefix sum of long array type

            for (int i = 1; i < A.Count; i++) // TC = O(N)
            {
                prefixSum.Add(prefixSum[i - 1] + A[i]);
            }

            for (int i = 0; i < B.Count; i++) // TC = O(Q) & SC = O(1)   | Q = B.Count
            {
                /*
                    Problem Constraints
                        1 <= N, M <= 10 ^ 5
                        1 <= A[i] <= 10 ^ 9
                        1 <= L <= R <= N
                */
                int fromIndex = B[i][0] - 1;
                int toIndex = B[i][1] - 1;

                if (fromIndex == 0 )
                    result.Add(prefixSum[toIndex]);
                else
                    result.Add(prefixSum[toIndex] - prefixSum[fromIndex - 1]);
            }

            return result;
        }
    }
}
