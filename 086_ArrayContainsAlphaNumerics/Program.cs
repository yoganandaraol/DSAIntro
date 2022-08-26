/*
 * ####################################################################
 * 
 * Problem 1 Description:
 * --------------------
        You are given a function isalpha() consisting of a character array A.

        Return 1 if all the characters of the character array are alphabetical (a-z and A-Z), 
        else return 0.

    Problem Constraints
    -------------------
        1 <= |A| <= 10^5

    Output Format
    -------------
        Return 1 if all the characters of the character array are alphabetical (a-z and A-Z), 
        else return 0.

    Sample Input:
    ------------
        A = ['S', 'c', 'A', 'l', 'e', 'r', 'A', 'c', 'a', 'D', 'e', 'm', 'y']

    Sample Output:
    -------------
        1

    Sample Input:
    ------------
        A = ['S', 'c', 'a', 'l', 'e', 'r', '#', '2', '0', '2', '0']

    Sample Output:
    -------------
        0


-----------------------------------------------------------------------------------


Problem 2 Description:
 * --------------------
       You are given a function isalphanumeric() consisting of a character array A.

        Return 1 if all the characters of a character array are alphanumeric (a-z, A-Z, and 0-9) 
        else, return 0.

    Problem Constraints
    -------------------
        1 <= |A| <= 10^5

    Output Format
    -------------
        Return 1 if all the characters of the character array are alphanumeric (a-z, A-Z and 0-9), 
        else return 0.

    Sample Input:
    ------------
        A = ['S', 'c', 'A', 'l', 'e', 'r', 'A', 'c', 'a', 'D', 'e', 'm', 'y']

    Sample Output:
    -------------
        1 // it has all alphabets

     Sample Input:
    ------------
        A = ['S', 'c', 'A', 'l', 'e', 'r', 'A', 'c', 'a', 'D', 'e', 'm', 'y', '0']

    Sample Output:
    -------------
        1 // it has all alphabets & 1 numeric value


    Sample Input:
    ------------
        A = ['S', 'c', 'a', 'l', 'e', 'r', '#', '2', '0', '2', '0']

    Sample Output:
    -------------
        0   // it has special chars


 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;

namespace _086_ArrayContainsAlphaNumerics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Is Alphabets - test cases
            List<char> inputA = new List<char> { 'S', 'c', 'A', 'l', 'e', 'r', 'A', 'c', 'a', 'D', 'e', 'm', 'y' };
            Console.WriteLine(IsAlpha(inputA) == 1 ? "Passed" : "Failed");

            inputA = new List<char> { 'S', 'c', 'a', 'l', 'e', 'r', '#', '2', '0', '2', '0' };
            Console.WriteLine(IsAlpha(inputA) == 0 ? "Passed" : "Failed");


            // Is Alphanumerics - test cases
            inputA = new List<char> { 'S', 'c', 'A', 'l', 'e', 'r', 'A', 'c', 'a', 'D', 'e', 'm', 'y' };
            Console.WriteLine(IsAlphaNumeric(inputA) == 1 ? "Passed" : "Failed");

            inputA = new List<char> { 'S', 'c', 'A', 'l', 'e', 'r', 'A', 'c', 'a', 'D', 'e', 'm', 'y', '0' };
            Console.WriteLine(IsAlphaNumeric(inputA) == 1 ? "Passed" : "Failed");

            inputA = new List<char> { 'S', 'c', 'a', 'l', 'e', 'r', '#', '2', '0', '2', '0' };
            Console.WriteLine(IsAlphaNumeric(inputA) == 0 ? "Passed" : "Failed");

        }

        static int IsAlpha(List<char> A)
        {
            for (int i = 0; i < A.Count; i++)
            {
                if (!((A[i] >= 'a' && A[i] <= 'z') || (A[i] >= 'A' && A[i] <= 'Z')))
                    return 0;
            }
            return 1;
        }

        static int IsAlphaNumeric(List<char> A)
        {
            for (int i = 0; i < A.Count; i++)
            {
                if (!((A[i] >= 'a' && A[i] <= 'z') || (A[i] >= 'A' && A[i] <= 'Z') || (A[i] >= '0' && A[i] <= '9')))
                    return 0;
            }
            return 1;
        }


    }
}
