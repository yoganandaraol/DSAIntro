
/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Given an integer array A, 
        find if an integer p exists in the array such that the number of integers greater than p in the array equals p.

    Problem Constraints
    -------------------
        1 <= |A| <= 2*10^5
        1 <= A[i] <=  10^7

    Output Format
    -------------
        Return 1 if any such integer p is present else, return -1.

    Sample Input:
    ------------
        A = [3, 2, 1, 3]

    Sample Output:
    -------------
        1

        Explanation:
            For integer 2, there are 2 greater elements in the array

    Sample Input:
    ------------
        [1, 1, 3, 3]

    Sample Output:
    -------------
        -1
        
        Explanation:
            There exist no integer satisfying the required conditions
 * 
 * ####################################################################
 */
using System;
using System.Collections.Generic;

namespace _075_NobleElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = new List<int> { 3, 2, 1, 3 };
            Console.WriteLine(NobleElementInArray(inputA) == 1 ? "Passed" : "Failed");
            inputA = new List<int> { 1, 1, 3, 3 };
            Console.WriteLine(NobleElementInArray(inputA) == -1 ? "Passed" : "Failed");
        }

        static int NobleElementInArray(List<int> A)
        {
            A.Sort((a, b) => b.CompareTo(a));
            int count = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (i > 0 && A[i] != A[i-1])
                {
                    count = i;
                }

                if (A[i] == count)
                    return 1;

            }
            return -1;
            
        }
    }
}
