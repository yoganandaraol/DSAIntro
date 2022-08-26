/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Find the number of occurrences of bob in string A consisting of lowercase English alphabets.

    Problem Constraints
    -------------------
        1 <= |A| <= 1000

    Output Format
    -------------
        Return an integer containing the answer.

    Sample Input:
    ------------
        "abobc"

    Sample Output:
    -------------
        1

        Explanation:
            The only occurrence is at second position.

    Sample Input:
    ------------
        "bobob"

    Sample Output:
    -------------
        2
        
        Explanation:
            bob occures at first and third position.
 * 
 * ####################################################################
 */

using System;

namespace _083_CountOfOccurances
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountOfOccurances("abobc") == 1 ? "Passed" : "Failed");
            Console.WriteLine(CountOfOccurances("bobob") == 2 ? "Passed" : "Failed");
        }

        static int CountOfOccurances(string A)
        {
            int count = 0;
            for (int i = 1; i < A.Length-1; i++)
            {
                if (A[i] == 'o')
                {
                    if (A[i - 1] == A[i + 1] && A[i - 1] == 'b') count++;
                }
            }
            return count;
        }
    }
}
