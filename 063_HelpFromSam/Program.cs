/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Alex and Sam are good friends. 
        Alex is doing a lot of programming these days. 
        He has set a target score of A for himself.

        Initially, Alex's score was zero. 
        Alex can double his score by doing a question, or Alex can seek help from Sam for doing questions that will contribute 1 to Alex's score. 
        Alex wants his score to be precisely A. Also, he does not want to take much help from Sam.

        Find and return the minimum number of times Alex needs to take help from Sam to achieve a score of A.


    Problem Constraints
    -------------------
        1 <= A <= 10^9

    Output Format
    -------------
        Return the minimum number of times help taken from Sam.

    Sample Input:
    ------------
         A = 5

    Sample Output:
    -------------
        2
        Explanation:
            Initial score : 0
            Takes help from Sam, score : 1
            Alex solves a question, score : 2
            Alex solves a question, score : 4
            Takes help from Sam, score: 5

    Sample Input:
    ------------
         A = 3

    Sample Output:
    -------------
        2
        Explanation:
            Initial score : 0
            Takes help from Sam, score : 1
            Alex solves a question, score : 2
            Takes help from Sam, score : 3
 * 
 * ####################################################################
 */

using System;

namespace _063_HelpFromSam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HelpTakenFromSam(5) == 2 ? "Passed" : "Failed");
            Console.WriteLine(HelpTakenFromSam(3) == 2 ? "Passed" : "Failed");
            Console.WriteLine(HelpTakenFromSam(64) == 1 ? "Passed" : "Failed");
            Console.WriteLine(HelpTakenFromSam(255) == 8 ? "Passed" : "Failed");
            Console.WriteLine(HelpTakenFromSam(256) == 1 ? "Passed" : "Failed");
            Console.WriteLine(HelpTakenFromSam(1000000000) == 13 ? "Passed" : "Failed");
        }

        static int HelpTakenFromSam(int A)
        {
            // Count the 1's occured in int A
            int minCount = 0;
            while (A > 0)
            {
                if ((A | 1) == A) // Checking last bit is 1 or not
                    minCount++;

                A >>= 1;
            }
            return minCount;
        }
    }
}
