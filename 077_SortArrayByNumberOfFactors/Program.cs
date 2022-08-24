/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        You are given an array A of N elements. 
        Sort the given array in increasing order of number of distinct factors of each element, 
        i.e., element having the least number of factors should be the first to be displayed 
        and the number having highest number of factors should be the last one. 
        If 2 elements have same number of factors, then number with less value should come first.

    Problem Constraints
    -------------------
        1 <= N <=    10^4
        1 <= A[i] <= 10^4

    Output Format
    -------------
        Return an array of integers.

    Sample Input:
    ------------
        A = [6, 8, 9]

    Sample Output:
    -------------
        [9, 6, 8]

        Explanation:
            The number 9 has 3 factors, 6 has 4 factors and 8 has 4 factors.

    Sample Input:
    ------------
        A = [2, 4, 7]

    Sample Output:
    -------------
        [2, 7, 4]
        
        Explanation:
            The number 2 has 2 factors, 7 has 2 factors and 4 has 3 factors.
 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace _077_SortArrayByNumberOfFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = new List<int> { 6, 8, 9 };
            Console.WriteLine(Enumerable.SequenceEqual(SortByNumberOfFactorsV1(inputA), new List<int> { 9, 6, 8 }) ? "Passed" : "Failed");

            inputA = new List<int> { 2, 4, 7 };
            Console.WriteLine(Enumerable.SequenceEqual(SortByNumberOfFactorsV1(inputA), new List<int> { 2, 7, 4 }) ? "Passed" : "Failed");

            inputA = new List<int> { 36, 13, 13, 26, 37, 28, 27, 43, 7 };
            Console.WriteLine(Enumerable.SequenceEqual(SortByNumberOfFactorsV1(inputA), new List<int> { 7, 13, 13, 37, 43, 26, 27, 28, 36 }) ? "Passed" : "Failed");
        }

        // Brute force
        static List<int> SortByNumberOfFactors(List<int> A)
        {
            var result = new List<int>(A);

            for (int i = 0; i < A.Count; i++)
            {
                result[i] = FactorsOfN(A[i]);
            }

            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 1; j < A.Count; j++)
                {
                    if (result[j] < result[j - 1])
                    {
                        Swap(result, j, j - 1);
                        Swap(A, j, j - 1);
                    }
                    else if (result[j] == result[j - 1])
                    {
                        if (A[j] < A[j-1])
                        {
                            Swap(A, j, j - 1);
                        }

                    }
                }
                
            }
            return A;
        }

        static int FactorsOfN(int N)
        {
            int count = 0;
            for (int i = 1; i*i <= N; i++)
            {
                if (i * i == N) count++;
                else if (N%i == 0) count += 2;
            }
            return count;
        }

        static void Swap(List<int> A, int lIndex, int rIndex)
        {
            int temp = A[lIndex];
            A[lIndex] = A[rIndex];
            A[rIndex] = temp;
        }

        static List<int> SortByNumberOfFactorsV1(List<int> A)
        {
            var result = new List<FactorsElement>();

            for (int i = 0; i < A.Count; i++)
                result.Add(new FactorsElement(A[i], FactorsOfN(A[i])));

            result.Sort((a, b) =>  a.Factors == b.Factors ? a.Element.CompareTo(b.Element) : a.Factors.CompareTo(b.Factors));
            return result.Select(a => a.Element).ToList();
        }

        class FactorsElement {
            public int Element;
            public int Factors;

            public FactorsElement(int element, int factors)
            {
                this.Element = element;
                this.Factors = factors;
            }
        }

        // TODO : Extend Comparer for List
    }
}
