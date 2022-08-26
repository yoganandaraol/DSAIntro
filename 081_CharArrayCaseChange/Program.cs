/*
 * ####################################################################
 * 
 * Problem 1 Description:
 * --------------------
        You are given a function to_lower() which takes a character array A as an argument.

        Convert each character of A into lowercase characters if it exists. 
        If the lowercase of a character does not exist, it remains unmodified.

        The uppercase letters from A to Z are converted to lowercase letters from a to z respectively.

        Return the lowercase version of the given character array.

    Problem Constraints
    -------------------
        1 <= |A| <= 10^5

    Output Format
    -------------
        Return the lowercase version of the given character array.

    Sample Input:
    ------------
        A = ['S', 'c', 'A', 'l', 'e', 'r', 'A', 'c', 'a', 'D', 'e', 'm', 'y']

    Sample Output:
    -------------
        ['s', 'c', 'a', 'l', 'e', 'r', 'a', 'c', 'a', 'd', 'e', 'm', 'y']


-----------------------------------------------------------------------------------


Problem 2 Description:
 * --------------------
       You are given a function to_upper() consisting of a character array A.

        Convert each charater of A into Uppercase character if it exists. 
        If the Uppercase of a character does not exist, it remains unmodified.
        The lowercase letters from a to z is converted to uppercase letters from A to Z respectively.

        Return the uppercase version of the given character array.

    Problem Constraints
    -------------------
        1 <= |A| <= 10^5

    Output Format
    -------------
        Return the uppercase version of the given character array.

    Sample Input:
    ------------
        A = ['S', 'c', 'A', 'L', 'E', 'r', 'A', 'c', 'a', 'D', 'e', 'm', 'y']

    Sample Output:
    -------------
        ['S', 'C', 'A', 'L', 'E', 'R', 'A', 'C', 'A', 'D', 'E', 'M', 'Y']


    Sample Input:
    ------------
        A = ['S', 'c', 'a', 'L', 'e', 'R', '#', '2', '0', '2', '0']

    Sample Output:
    -------------
        ['S', 'C', 'A', 'L', 'E', 'R', '#', '2', '0', '2', '0']


 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace _081_CharArrayCaseChange
{
    class Program
    {
        static void Main(string[] args)
        {
            // TO LOWER - test cases
            List<char> inputA = new List<char> { 'S', 'c', 'A', 'l', 'e', 'r', 'A', 'c', 'a', 'D', 'e', 'm', 'y' };
            List<char> output = new List<char> { 's', 'c', 'a', 'l', 'e', 'r', 'a', 'c', 'a', 'd', 'e', 'm', 'y' };
            Console.WriteLine(Enumerable.SequenceEqual(To_lower(inputA), output) ? "Passed" : "Failed");


            // TO UPPER - test cases
            inputA = new List<char> { 'S', 'c', 'A', 'L', 'E', 'r', 'A', 'c', 'a', 'D', 'e', 'm', 'y' };
            output = new List<char> { 'S', 'C', 'A', 'L', 'E', 'R', 'A', 'C', 'A', 'D', 'E', 'M', 'Y' };
            Console.WriteLine(Enumerable.SequenceEqual(To_upper(inputA), output) ? "Passed" : "Failed");

            inputA = new List<char> { 'S', 'c', 'a', 'L', 'e', 'R', '#', '2', '0', '2', '0' };
            output = new List<char> { 'S', 'C', 'A', 'L', 'E', 'R', '#', '2', '0', '2', '0' };
            Console.WriteLine(Enumerable.SequenceEqual(To_upper(inputA), output) ? "Passed" : "Failed");

        }

        static List<char> To_lower(List<char> A)
        {
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] >= 'A' && A[i] <= 'Z')
                    A[i] = (char)(A[i] + ('a' - 'A'));  // Upper case char + 32 is lower case char
            }
            return A;
        }

        static List<char> To_upper(List<char> A)
        {
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] >= 'a' && A[i] <= 'z')
                    A[i] = (char)(A[i] - ('a' - 'A'));  // Lower case char - 32 is lower case char
            }
            return A;
        }
    }

    
}
