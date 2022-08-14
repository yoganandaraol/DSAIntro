/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        You are given two integers A and B.
        Set the A-th bit and B-th bit in 0, and return output in decimal.

    Problem Constraints
    -------------------
        0 <= A <= 30
        0 <= B <= 30

    Output Format
    -------------
        Return an integer of updated value.

    Sample Input:
    ------------
        A = 3
        B = 5

    Sample Output:
    -------------
        40
        Explanation:
            The binary expression is 101000 which is 40 in decimal.

    Sample Input:
    ------------
        A = 4
        B = 4

    Sample Output:
    -------------
        16
        Explanation:
            The binary expression is 10000 which is 16 in decimal

 * 
 * ####################################################################
 */

using System;

namespace _059_SetBit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SetBitsAndReturnUpdatedValue(3, 5) == 40 ? "Passed" : "Failed");
            Console.WriteLine(SetBitsAndReturnUpdatedValue(4, 4) == 16 ? "Passed" : "Failed");
        }

        static int SetBitsAndReturnUpdatedValue(int A, int B)
        {
            return 1 << A | 1 << B;
        }
    }
}
