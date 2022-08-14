/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Given a binary string A. 
        It is allowed to do at most one swap between any 0 and 1. 
        Find and return the length of the longest consecutive 1’s that can be achieved.

    Problem Constraints
    -------------------
        1 <= length of string <= 1000000
        A contains only characters 0 and 1.

    Output Format
    -------------
        Return the length of the longest consecutive 1’s that can be achieved.

    Sample Input:
    ------------
         A = "111000"

    Sample Output:
    -------------
        3

    Sample Input:
    ------------
         A = "111011101"

    Sample Output:
    -------------
        7
 * 
 * ####################################################################
 */

using System;

namespace _044_LongestConsecutiveOnesInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestConsecutiveOnes("11110001"));
        }

        static int LongestConsecutiveOnes(string A)
        {
            int maxLen = 0;

            var charsArr = A.ToCharArray();
            int[] zeroDistances = new int[charsArr.Length];

            char prevChar = charsArr[0];

            int onesCount = 0;
            int zerosCount = 0;
            for (int i = 0; i < charsArr.Length; i++)
            {
                if (charsArr[i] == '1')
                {
                    onesCount++;
                    if (prevChar == charsArr[i]) maxLen++;
                }
                else 
                {
                    zerosCount++;
                }
                prevChar = charsArr[i];
            }

            if (onesCount == maxLen) return onesCount;

            return maxLen;
        }
    }
}
