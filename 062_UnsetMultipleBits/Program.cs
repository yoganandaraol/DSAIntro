/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Given an integer A. Unset B bits from the right of A in binary.
        For eg:-
            A = 93, B = 4
            A in binary = 1011101
            A should become = 1010000 = 80. Therefore return 80.

    Problem Constraints
    -------------------
        1 <= A <= 10^18
        1 <= B <= 60

    Output Format
    -------------
        Return updated number after B bits reset from right.

    Sample Input:
    ------------
        A = 25
        B = 3

    Sample Output:
    -------------
        24
        Explanation:
            A = 11001 to 11000

    Sample Input:
    ------------
        A = 37
        B = 3

    Sample Output:
    -------------
        32
        Explanation:
            A = 100101 to 100000
 * 
 * ####################################################################
 */

using System;

namespace _062_UnsetMultipleBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UnsetMultipleBitsFromRight(25, 3) == 24 ? "Passed" : "Failed");
            Console.WriteLine(UnsetMultipleBitsFromRight(37, 3) == 32 ? "Passed" : "Failed");
        }

        static long UnsetMultipleBitsFromRight(long A, int B)
        {
            for (int i = 0; i < B; i++)
                A = (A | (1 << i)) == A ? A ^ (1 << i) : A;
            return A;
        }
    }
}
