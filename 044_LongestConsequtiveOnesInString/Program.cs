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
            Console.WriteLine(LongestConsecutiveOnes("11110001") == 5 ? "Passed" : "Failed");
            Console.WriteLine(LongestConsecutiveOnes("1111000") == 4 ? "Passed" : "Failed");
            Console.WriteLine(LongestConsecutiveOnes("111011101") == 7 ? "Passed" : "Failed");
            Console.WriteLine(LongestConsecutiveOnes("11101110") == 6 ? "Passed" : "Failed");
            Console.WriteLine(LongestConsecutiveOnes("11010110000000000") == 4 ? "Passed" : "Failed");
            Console.WriteLine(LongestConsecutiveOnes("1111111111") == 10 ? "Passed" : "Failed");
            Console.WriteLine(LongestConsecutiveOnes("00000000") == 0 ? "Passed" : "Failed");
        }

        static int LongestConsecutiveOnes(string A)
        {
            int maxLen = 0;
            int onesCount = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int leftCount = 0;
                int rightCount = 0;

                if (A[i] == '0')
                {
                    for (int j = i-1; j >= 0; j--)
                    {
                        if (A[j] == '0')
                            break;
                        leftCount++;
                    }

                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (A[j] == '0')
                            break;
                        rightCount++;
                    }
                    maxLen = Math.Max(maxLen, leftCount + rightCount);
                }
                else onesCount++;
            }

            if (onesCount == 0) return 0;
            if (maxLen == 0) return onesCount;
            
            return maxLen == onesCount ? maxLen : maxLen + 1;
        }
    }
}
