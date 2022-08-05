/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
    You are given an integer array A of length N comprising of 0's & 1's, and an integer B.

    You have to tell all the indices of array A that can act as a center of 2 * B + 1 length
    0-1 alternating subarray.

    A 0-1 alternating array is an array containing only 0's & 1's, and having no adjacent 0's or 1's. 
    For e.g. 
        arrays [0, 1, 0, 1], [1, 0] and [1] are 0-1 alternating, 
        while [1, 1] and [0, 1, 0, 0, 1] are not.

    Problem Constraints
    -------------------
        1 <= N <= 10^3
        A[i] equals to 0 or 1.
        0 <= B <= (N - 1) / 2

    Output Format
    -------------
        Return an integer array containing indices(0-based) in sorted order. 
        If no such index exists, return an empty integer array.

    Sample Input:
    ------------
        A = [1, 0, 1, 0, 1]
        B = 1 

    Sample Output:
    -------------
        [1, 2, 3]


    Sample Input:
    ------------
        A = [0, 0, 0, 1, 1, 0, 1]
        B = 0  

    Sample Output:
    -------------
        [0, 1, 2, 3, 4, 5, 6]

 * 
 * ####################################################################
 */


using System;
using System.Collections.Generic;

namespace _033_Alternating_Subarrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = new List<int> { 1, 0, 1, 0, 1 };
            var inputB = 1;

            //var inputA = new List<int> { 0, 0, 0, 1, 1, 0, 1 };
            //var inputB = 0;

            //var inputA = new List<int> { 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 0 };
            //var inputB = 2;

            var result = AlternatingSubArray(inputA, inputB);
            if (result.Count > 0)
            {
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            else
                Console.WriteLine("No subarrays with altering values");

        }

        static List<int> AlternatingSubArray(List<int> A, int B)
        {
            var ciArray = new List<int>();
            // center index of first sub array is 

            for (int ci = B; ci + B < A.Count; ci++)
            {
                // find alternative index in correct order 
                int count = 0;
                int searchElement = A[ci];
                for (int i = 1; i < B + 1; i++)
                {
                    if (B == 0)
                    {
                        count++;
                        continue;
                    }
                    searchElement = searchElement == 0 ? 1 : 0;
                    if (A[ci - i] == A[ci + i] && A[ci - i] == searchElement) count++;
                }

                if (count == B)
                {
                    ciArray.Add(ci);
                }
            }
            return ciArray;
        }
    }
}
