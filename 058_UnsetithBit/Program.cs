/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        You are given two integers A and B.
            * If B-th bit in A is set, make it unset
            * If B-th bit in A is unset, leave it as it is
        Return the updated A value

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
        4
        Explanation:
            Given N = 4 which is 100 in binary. The 1-st bit is already unset

    Sample Input:
    ------------
        A = 5
        B = 2

    Sample Output:
    -------------
        1
        Explanation:
            Given N = 5 which is 101 in binary. We unset the 2-nd bit

 * 
 * ####################################################################
 */
using System;

namespace _058_UnsetithBit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UnsetBthBit(4, 1) == 4 ? "Passed" : "Failed");
            Console.WriteLine(UnsetBthBit(5, 2) == 1 ? "Passed" : "Failed");
        }

        static int UnsetBthBit(int A, int B)
        {
            // Check B th bit is set or unset
            return (A | (1 << B)) == A ? (A ^ 1 << B) : A;
        }
    }
}
