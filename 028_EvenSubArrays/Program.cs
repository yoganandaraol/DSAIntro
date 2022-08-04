/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
    -> You are given an integer array A.
    -> Decide whether it is possible to divide the array into one or more subarrays 
    of even length such that the first and last element of all subarrays will be even.
    -> Return "YES" if it is possible; otherwise, return "NO" (without quotes).

    Problem Constraints
    -------------------
        1 <= |A|, A[i] <= 10^6

    Sample Input:
    ------------
        A = [2, 4, 8, 6]  -- YES

    Sample Input:
    -------------
        A = [2, 4, 8, 7, 6] -- NO
 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;

namespace _028_EvenSubArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<int> { 121, 351, 314, 562, 953, 319, 859, 413, 201, 640, 66, 723, 998, 612, 291, 539, 463, 340, 64, 251, 807, 457, 584, 944, 315, 327, 769, 675, 113, 364, 488, 579, 674, 340, 950, 516, 618, 599, 186, 496, 403, 450, 833, 79, 229, 150, 497, 256, 971, 687, 318, 717, 540, 126, 906, 843, 417, 557, 97, 370, 409, 148, 968, 562, 534, 845, 378 };
            Console.WriteLine(FindEvenSubArrays(input));
        }

        static string FindEvenSubArrays(List<int> A)
        {
            int arraySize = A.Count;
            if (arraySize % 2 == 1 || A[0] % 2 == 1 || A[arraySize - 1] % 2 == 1) return "NO";
            else return "YES";
            
        }
    }
}
