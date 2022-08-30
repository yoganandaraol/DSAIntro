/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Given a string A of size N, find and return the longest palindromic substring in A.

        Substring of string A is A[i...j] where 0 <= i <= j < len(A)

        Palindrome string:
        A string which reads the same backwards. More formally, A is palindrome if reverse(A) = A.

        Incase of conflict, return the substring which occurs first ( with the least starting index).

    Problem Constraints
    -------------------
        1 <= N <= 6000

    Output Format
    -------------
        Return a string denoting the longest palindromic substring of string A.

    Sample Input:
    ------------
        A = "aaaabaaa"

    Sample Output:
    -------------
        "aaabaaa"

        Explanation:
            We can see that longest palindromic substring is of length 7 and the string is "aaabaaa".

 * 
 * ####################################################################
 */

using System;

namespace _088_FindPalindromeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestPalindromicSubstringLength("aarevveraa") == 10 ? "Passed" : "Failed");
            Console.WriteLine(LongestPalindromicSubstringLength("aareveraaaa") == 9 ? "Passed" : "Failed");
            Console.WriteLine(LongestPalindromicSubstringLength("aaaareveraa") == 9 ? "Passed" : "Failed");
            Console.WriteLine(LongestPalindromicSubstringLength("revveraa") == 6 ? "Passed" : "Failed");
            Console.WriteLine(LongestPalindromicSubstringLength("aarevver") == 6 ? "Passed" : "Failed");
            Console.WriteLine(LongestPalindromicSubstringLength("abb") == 2 ? "Passed" : "Failed");

            Console.WriteLine(LongestPalindromicSubstring("aarevveraa") == "aarevveraa" ? "Passed" : "Failed");
            Console.WriteLine(LongestPalindromicSubstring("aareveraaaa") == "aareveraa" ? "Passed" : "Failed");
            Console.WriteLine(LongestPalindromicSubstring("aaaareveraa") == "aareveraa" ? "Passed" : "Failed");
            Console.WriteLine(LongestPalindromicSubstring("revveraa") == "revver" ? "Passed" : "Failed");
            Console.WriteLine(LongestPalindromicSubstring("aarevver") == "revver" ? "Passed" : "Failed");
            Console.WriteLine(LongestPalindromicSubstring("abb") == "bb" ? "Passed" : "Failed");
        }

        static int LongestPalindromicSubstringLength(string A)
        {
            int maxLen = 0;

            for (int i = 0; i < A.Length; i++)
            {
                maxLen = Math.Max(maxLen, PalindromicSubstringLength(A, i, i));
                if (i + 1 <= A.Length - 1)
                    maxLen = Math.Max(maxLen, PalindromicSubstringLength(A, i, i + 1));
            }
           
            return maxLen;
        }

        static string LongestPalindromicSubstring(string A)
        {
            int maxLen = 0;
            string maxSubString = string.Empty;
            for (int i = 0; i < A.Length; i++)
            {
                int len = PalindromicSubstringLength(A, i, i);
                if (len > maxLen)
                {
                    maxLen = len;
                    if (i == 0)
                        maxSubString = A.Substring(0, maxLen);
                    else
                        maxSubString = A.Substring(i - maxLen / 2, maxLen);
                }
                if (i + 1 <= A.Length - 1)
                {
                    len = PalindromicSubstringLength(A, i, i + 1);
                    if (len > maxLen)
                    {
                        maxLen = len;
                        if (i == 0)
                            maxSubString = A.Substring(0, maxLen);
                        else
                            maxSubString = A.Substring(i - ((maxLen / 2) - 1), maxLen);
                    }
                }
            }

            return maxSubString;
        }

        private static int PalindromicSubstringLength(string s, int lIndex, int rIndex)
        {
            int len = 0;
            if (lIndex == rIndex)
            {
                len = 1;
                if (lIndex == 0) return 1;
                for (int i = 1; lIndex - i >= 0 && lIndex + i < s.Length; i++)
                {
                    if (s[lIndex - i] == s[lIndex + i])
                        len += 2;
                    else break;
                }
            }
            else
            {
                if (s[lIndex] == s[rIndex])
                {
                    len = 2;
                    if (lIndex == 0) return len;

                    for (int i = 1; lIndex - i >= 0 && rIndex + i < s.Length; i++)
                    {
                        if (s[lIndex - i] == s[rIndex + i])
                            len += 2;
                        else break;
                    }
                }
            }

            return len;
        }

    }
}

