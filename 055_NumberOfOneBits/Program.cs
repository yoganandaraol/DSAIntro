/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Write a function that takes an integer and returns the number of 1 bits it has.

    Problem Constraints
    -------------------
        1 <= A <= 10^9

    Output Format
    -------------
        Return an integer as the answer

    Sample Input:
    ------------
         11

    Sample Output:
    -------------
        3
        Explanation:
            11 is represented as 1011 in binary.
            And it has three '1' bits

 * 
 * ####################################################################
 */

using System;

namespace _055_NumberOfOneBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OneBitsCount(11) == 3 ? "Passed" : "Failed");
            Console.WriteLine(OneBitsCount(10) == 2 ? "Passed" : "Failed");
            Console.WriteLine(OneBitsCount(1000000000) == 13 ? "Passed" : "Failed");
        }

        static int OneBitsCount(int A)
        {
            int onesCount = 0;
            while (A > 0)
            {
                if ((A & 1) == 1) onesCount++;
                A >>= 1;
            }
            return onesCount;
        }
    }
}
