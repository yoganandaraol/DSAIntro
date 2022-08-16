/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        You are given an array A consisting of heights of Christmas trees and an array B of the same size consisting of the cost of each of the trees (Bi is the cost of tree Ai, where 1 ≤ i ≤ size(A)), and you are supposed to choose 3 trees (let's say, indices p, q, and r), such that Ap < Aq < Ar, where p < q < r.
        The cost of these trees is Bp + Bq + Br.

        You are to choose 3 trees such that their total cost is minimum. Return that cost.

        If it is not possible to choose 3 such trees return -1.

    Problem Constraints
    -------------------
        1 <= A[i], B[i] <= 10^9
        3 <= size(A) = size(B) <= 3000

    Output Format
    -------------
        Return an integer denoting the minimum cost of choosing 3 trees whose heights are strictly in increasing order, if not possible, -1.

    Sample Input:
    ------------
        A = [1, 3, 5]
        B = [1, 2, 3]

    Sample Output:
    -------------
        6

    Sample Input:
    ------------
        A = [1, 6, 4, 2, 6, 9]
        B = [2, 5, 7, 3, 2, 7]

    Sample Output:
    -------------
        7
 * 
 * ####################################################################
 */


using System;
using System.Collections.Generic;

namespace _045_LowestPriceCristmasTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = new List<int> { 1, 3, 5 };
            var inputB = new List<int> { 1, 2, 3 };
            Console.WriteLine(LeastPriceChristmasTree(inputA, inputB) == 6 ? "Passed" : "Failed");

            inputA = new List<int> { 1, 6, 4, 2, 6, 9 };
            inputB = new List<int> { 2, 5, 7, 3, 2, 7 };
            Console.WriteLine(LeastPriceChristmasTree(inputA, inputB) == 7 ? "Passed" : "Failed");

            inputA = new List<int> { 5, 9, 10, 4, 7, 8 };
            inputB = new List<int> { 5, 6, 4, 7, 2, 5 };
            Console.WriteLine(LeastPriceChristmasTree(inputA, inputB) == 12 ? "Passed" : "Failed");

            inputA = new List<int> { 2, 4, 5, 4, 10 };
            inputB = new List<int> { 40, 30, 20, 10, 10 };
            Console.WriteLine(LeastPriceChristmasTree(inputA, inputB) == 60 ? "Passed" : "Failed");

            inputA = new List<int> { 2, 4, 5, 4, 10 };
            inputB = new List<int> { 40, 30, 20, 10, 70 };
            Console.WriteLine(LeastPriceChristmasTree(inputA, inputB) == 90 ? "Passed" : "Failed");
        }

        static int solve(List<int> A, List<int> B)
        {
            if (A.Count >= 3)
            {
                int min1 = int.MaxValue - 3;
                int min2 = int.MaxValue - 2;
                int min3 = int.MaxValue - 1;
                int minIndex1 = A.Count-2;
                int minIndex2 = A.Count-1;
                int minIndex3 = A.Count;

                for (int i = 0; i < A.Count; i++)
                {
                    if (A[i] <= min1)
                    {
                        if (minIndex1 < A.Count && minIndex2 < A.Count && minIndex3 < A.Count)
                        {
                            if (B[i] < B[minIndex1])
                            {
                                min3 = int.MaxValue - 1;
                                minIndex3 = A.Count - 2;
                                min2 = int.MaxValue - 2;
                                minIndex2 = A.Count - 1;
                                min1 = A[i];
                                minIndex1 = i;
                            }
                        }
                        else
                        {
                            min1 = A[i];
                            minIndex1 = i;
                        }

                    }
                    else if (A[i] <= min2)
                    {
                        if (minIndex1 < A.Count && minIndex2 < A.Count && minIndex3 < A.Count)
                        {
                            if (B[i] < B[minIndex2])
                            {
                                min3 = int.MaxValue - 1;
                                minIndex3 = A.Count - 2;
                                min2 = A[i];
                                minIndex2 = i;
                            }
                        }
                        else
                        {
                            min2 = A[i];
                            minIndex2 = i;
                        }

                    }
                    else if (A[i] <= min3)
                    {
                        if (minIndex1 < A.Count && minIndex2 < A.Count && minIndex3 < A.Count)
                        {
                            if (B[i] < B[minIndex3])
                            {
                                min3 = A[i];
                                minIndex3 = i;
                            }
                        }
                        else
                        {
                            min3 = A[i];
                            minIndex3 = i;
                        }
                    }

                }

                if (minIndex1 == A.Count || minIndex2 == A.Count || minIndex3 == A.Count) return -1;

                return B[minIndex1] + B[minIndex2] + B[minIndex3];
            }
            else return -1;
        }

        static int LeastPriceChristmasTree(List<int> A, List<int> B)
        {
            int min = int.MaxValue;

            if (A.Count >= 3)
            {
                for (int i = 0; i < A.Count; i++)
                {
                    int leftMin = int.MaxValue;
                    for (int j = 0; j < i; j++)
                    {
                        if (A[j] < A[i])
                        {
                            leftMin = Math.Min(leftMin, B[j] + B[i]);
                        }
                    }

                    for (int j = i+1; j < A.Count; j++)
                    {
                        if (A[j] > A[i] && leftMin != int.MaxValue)
                        {
                            min = Math.Min(min, leftMin + B[j]);
                        }
                    }
                }
            }

            return min == int.MaxValue ? -1 : min;
        }
    }
}
