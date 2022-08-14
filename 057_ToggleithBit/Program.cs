/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        You are given two integers A and B.
            * If B-th bit in A is set, make it unset
            * If B-th bit in A is unset, make it set

    Problem Constraints
    -------------------
        1 <= A <= 10^9
        0 <= B <= 30

    Output Format
    -------------
        Return an integer of updated value.

    Sample Input:
    ------------
        A = 4
        B = 1

    Sample Output:
    -------------
        6
        Explanation:
            Given N = 4 which is 100 in binary. The 1-st bit is unset
            so we make it set

    Sample Input:
    ------------
        A = 5
        B = 2

    Sample Output:
    -------------
        1
        Explanation:
            Given N = 5 which is 101 in binary. The 2-nd bit is set
            so we make it unset

 * 
 * ####################################################################
 */

using System;

namespace _057_ToggleithBit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToggleBthBit(4, 1) == 6 ? "Passed" : "Failed");
            Console.WriteLine(ToggleBthBit(5, 2) == 1 ? "Passed" : "Failed");
        }

        static int ToggleBthBit(int A, int B)
        {
            // XOR toggles B th bit in case, A XOR with 1 left shift B times
            return (A ^ 1 << B);
        }
    }
}
