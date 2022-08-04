
/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
    You are given an array of integers A of size N.
    Return the difference between the maximum among all even numbers of A
    and the minimum among all odd numbers in A.

    Problem Constraints
    -------------------
        2 <= N <= 1e5
        -1e9 <= A[i] <= 1e9
        There is atleast 1 odd and 1 even number in A

    Sample Input 1:
    ------------
        A = [0, 2, 9]

    Sample Output 1:
    -------------
        -7


    Sample Input 2:
    ------------
        A = [5, 17, 100, 1]

    Sample Output 2:
    -------------
        99
 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;

namespace _015_MinimumPicks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Solve(new List<int> { 0, 2, 9}));
            Console.WriteLine(SolveXtra(new List<int> { -92, 22, 2, 11, 39, 36, 36, 51, 71, 42 }));
            //Console.WriteLine(SolveXtra(new List<int> { 91, 76, 81, 73, 64, 13, -63, 8, 60, 27 }));
        }

        static int Solve(List<int> A)
        {
            int max = -1, min = 0;
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = i+1; j < A.Count; j++)
                {
                    if (A[i] < A[j])
                    {
                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;

                        if (A[j] % 2 != 0)
                        {
                            if (min == 0 || A[j] < min) min = A[j];
                        }
                        if (A[i] % 2 == 0)
                        {
                            if (max == -1 || A[i] > max) max = A[i];
                        }
                    }
                    else
                    {
                        if (A[i] % 2 != 0)
                        {
                            if (min == 0 || A[i] < min) min = A[i];
                        }
                        if (A[j] % 2 == 0)
                        {
                            if (max == -1 || A[j] > max) max = A[j];
                        }
                    }
                    

                }
            }
            return max - min;
        }

        static int SolveXtra(List<int> A)
        {
            int min = 0, max = -1;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] % 2 != 0)
                {
                    if (min == 0 || A[i] < min) min = A[i];
                }
                if (A[i] % 2 == 0)
                {
                    if (max == -1 || A[i] > max) max = A[i];
                }

            }

            Console.WriteLine(string.Format("Min - {0}\t Max - {1}", min, max));
            return max - min;
        }
    }
}
