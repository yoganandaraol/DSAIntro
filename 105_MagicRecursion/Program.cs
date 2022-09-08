/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        On the first row, we write a 0. Now in every subsequent row, 
        we look at the previous row and replace each occurrence of 0 with 01, 
        and each occurrence of 1 with 10.

        Given row number A and index B, 
        return the Bth indexed symbol in row A. (The values of B are 1-indexed.).

    Problem Constraints
    -------------------
        1 <= A <= 20
        1 <= B <= 2^(A - 1)

    Output Format
    -------------
        Return an integer denoting the Bth indexed symbol in row A.

    Sample Input:
    ------------
        A = 2
        B = 1

    Sample Output:
    -------------
        0

        Explanation:
            Row 1: 0
            Row 2: 01

    Sample Input:
    ------------
        A = 2
        B = 2

    Sample Output:
    -------------
        1

        Explanation:
            Row 1: 0
            Row 2: 01
 * 
 * ####################################################################
 */

using System;

namespace _105_MagicRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MagicRecursion(2,2) == 1 ? "Passed" : "Failed");
            Console.WriteLine(MagicRecursion(4,2) == 1 ? "Passed" : "Failed");
            Console.WriteLine(MagicRecursion(5,4) == 0 ? "Passed" : "Failed");
        }

        static int MagicRecursion(int A, int B)
        {
            if (A == 1)
                return 0;

            int mid = (int)Math.Pow(2, A - 1) / 2;
            if (B <= mid)
                return MagicRecursion(A - 1, B);
            else
                return MagicRecursion(A - 1, B - mid) == 1 ? 0 : 1;
        }
    }
}
