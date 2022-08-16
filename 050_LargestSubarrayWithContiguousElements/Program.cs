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
            Console.WriteLine("Hello World!");
        }

        static int LargestSubarrayWithContiguousElements(List<int> A)
        {
            int largestArrSize = 0;
            //TODO
            return largestArrSize;
        }

    }
}
