/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        You are given a string A of size N consisting of lowercase alphabets.

        You can change at most B characters in the given string to any other lowercase alphabet such that the number of distinct characters in the string is minimized.

        Find the minimum number of distinct characters in the resulting string.

    Problem Constraints
    -------------------
        1 <= N <= 100000
        0 <= B < N

    
    Input Format:
    --------------
        The first argument is a string A.
        The second argument is an integer B.

    Output Format
    -------------
        Return an integer denoting the minimum number of distinct characters in the string.

    Sample Input:
    ------------
        A = "abcabbccd"
        B = 3

    Sample Output:
    -------------
        2

        Explanation:
            We can change both 'a' and one 'd' into 'b'.So the new string becomes "bbcbbbccb".
            So the minimum number of distinct character will be 2.

 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace _084_MinNumberOfDistinctChars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinDistinctCharsPostRemoval("abcabbccd", 3) == 2 ? "Passed" : "Failed");
        }

        static int MinDistinctCharsPostRemoval(string A, int B)
        {
            var freqs = new List<int>();
            freqs.AddRange(Enumerable.Repeat(0, 26));
            for (int i = 0; i < A.Length; i++)
                freqs[A[i] - 'a'] += 1;

            freqs.Sort();
            int count = freqs[0] > 0 && freqs[0] <= B ? 1 : 0;
            for (int i = 1; i < 26; i++)
            {
                freqs[i] += freqs[i - 1];
                if (freqs[i] > 0 && freqs[i] <= B)
                    count++;
            }

            var distictCharsA = A.ToCharArray().Distinct().ToArray();

            return distictCharsA.Length - count;
        }
    }
}
