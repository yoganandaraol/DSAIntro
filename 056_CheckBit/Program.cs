/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        You are given two integers A and B.
            * Return 1 if B-th bit in A is set
            * Return 0 if B-th bit in A is unset

    Problem Constraints
    -------------------
        1 <= A <= 10^9
        0 <= B <= 30

    Output Format
    -------------
        Return an iteger.

    Sample Input:
    ------------
        A = 4
        B = 1

    Sample Output:
    -------------
        0
        Explanation:
            Given N = 4 which is 100 in binary. The 1-st bit is unset
            so we return 0

    Sample Input:
    ------------
        A = 5
        B = 2

    Sample Output:
    -------------
        1
        Explanation:
            Given N = 5 which is 101 in binary. The 2-nd bit is set
            so we return 1
 * 
 * ####################################################################
 */

using System;

namespace _056_CheckBit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckTheBitSetOrNotWithXOR(4, 1) == 0?"Passed":"Failed");
            Console.WriteLine(CheckTheBitSetOrNotWithXOR(4, 2) == 1?"Passed":"Failed");
            Console.WriteLine(CheckTheBitSetOrNotWithXOR(5, 2) == 1?"Passed":"Failed");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">Input number of range 1 <= A <= 10^9</param>
        /// <param name="B">B th element in the binary number of input number A</param>
        /// <returns>returns 0 or 1 based on value set to Bth element</returns>
        static int CheckTheBitSetOrNotWithOR(int A, int B)
        {
            #region with OR operator
            var newNum = 1 << B;
            if ((A | newNum) == A) return 1;
            else return 0;
            #endregion
        }

        static int CheckTheBitSetOrNotWithAND(int A, int B)
        {
            #region with AND operator
            var newNum = 1 << B;
            if ((A & newNum) == 0) return 0;
            else return 1;
            #endregion
        }

        static int CheckTheBitSetOrNotWithXOR(int A, int B)
        {
            #region with XOR operator
            if ((A ^ (1 << B)) < A) return 1;
            else return 0;
            #endregion
        }
    }
}
