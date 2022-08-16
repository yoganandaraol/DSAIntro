/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Given a binary string A. It is allowed to do at most one swap between any 0 and 1.
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

namespace _046_LengthOfLongesConOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int LongestConsecutiveElements(string A)
        {
            int result = 0;
            var binaryElements = A.ToCharArray();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == '0')
                {
                    int countLeft = 0;
                    int countRight = 0;
                    for (int j = i-1; j >= 0; j--)
                    {
                        if (A[j] == '0') break;
                        countLeft++;
                    }

                    for (int j = i+1; j < A.Length; j++)
                    {
                        if (A[j] == '0') break;
                        countRight++;
                    }

                    
                }
            }
            return result;
        }
    }
}
