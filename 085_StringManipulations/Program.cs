/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Akash likes playing with strings. One day he thought of applying following operations on the string in the given order:

            Concatenate the string with itself.
            Delete all the uppercase letters.
            Replace each vowel with '#'.

        You are given a string A of size N consisting of lowercase and uppercase alphabets. 
        Return the resultant string after applying the above operations.

        NOTE: 'a' , 'e' , 'i' , 'o' , 'u' are defined as vowels.

    Problem Constraints
    -------------------
        1<=N<=100000

    Output Format
    -------------
        Return the resultant string.

    Sample Input:
    ------------
        A="AbcaZeoB"

    Sample Output:
    -------------
        "bc###bc###"

        Explanation:
            First concatenate the string with itself so string A becomes "AbcaZeoBAbcaZeoB".
            Delete all the uppercase letters so string A becomes "bcaeobcaeo".
            Now replace vowel with '#'.
            A becomes "bc###bc###".

 * 
 * ####################################################################
 */


using System;
using System.Text;

namespace _085_StringManipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringOperations("AbcaZeoB") == "bc###bc###" ? "Passed" : "Failed");
        }

        static string StringOperations(string A)
        {
            A += A;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] >= 'A' && A[i] <= 'Z') continue;
                else 
                {
                    if (A[i] == 'a' || A[i] == 'e' || A[i] == 'i' || A[i] == 'o' || A[i] == 'u')
                    {
                        sb.Append('#');
                        continue;
                    }
                    sb.Append(A[i]);
                }
            }

            return sb.ToString();
        }
    }
}
