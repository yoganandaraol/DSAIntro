/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Given an array with N objects colored red, white, or blue, sort them so that 
        objects of the same color are adjacent, with the colors in the order red, white, and blue.

        We will use the integers 0, 1, and 2 to represent red, white, and blue, respectively.

        Note: 
            Using the library sort function is not allowed.

    Problem Constraints
    -------------------
        1 <= N <= 1000000
        0 <= A[i] <= 2

    Output Format
    -------------
        Return an integer array in asked order

    Sample Input:
    ------------
        A = [0 1 2 0 1 2]

    Sample Output:
    -------------
        [0 0 1 1 2 2]

    Sample Input:
    ------------
        A = [0]

    Sample Output:
    -------------
        [0]
        
 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace _078_SortByColor
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = new List<int> { 0, 1, 2, 0, 1, 2 };
            Console.WriteLine(Enumerable.SequenceEqual(sortColors(inputA), new List<int> { 0, 0, 1, 1, 2, 2 }) ? "Passed" : "Failed");

            inputA = new List<int> { 2, 0, 0, 1, 0, 0, 2, 2, 1, 1, 0, 0, 1, 0, 2, 1, 1, 0, 1, 0, 1, 2, 2, 2, 0, 0, 1, 0, 2, 1, 1, 2, 1, 2, 2, 1, 0, 2, 2, 1, 1, 1, 0, 1, 0, 1, 0, 2, 1, 2, 0, 2, 0, 1, 1, 0, 2, 2, 1, 2, 0, 2, 1, 1, 1, 2, 0, 1, 0, 2, 2, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 2, 1, 1, 0, 2, 1, 2, 0, 0, 0, 2, 2, 2, 2, 0, 0, 0, 1, 1, 0, 2, 1, 2, 2, 2, 1, 2, 2, 0, 1, 0, 1, 2, 1, 1, 0, 1, 2, 0, 1, 0, 2, 2, 1, 2, 1, 0, 2, 2, 1, 1, 0, 2, 1, 2 };
            Console.WriteLine(Enumerable.SequenceEqual(sortColors(inputA), new List<int> { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,}) ? "Passed" : "Failed");
        }

        static List<int> sortColors(List<int> A)
        {
            int countR = 0, countW = 0, countB = 0;

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] == 0) countR++;
                else if (A[i] == 1) countW++;
                else if (A[i] == 2) countB++;
            }

            for (int i = 0; i < A.Count; i++)
            {
                if (countR > 0)
                {
                    A[i] = 0;
                    countR--;
                }
                else if (countW > 0)
                {
                    A[i] = 1;
                    countW--;
                }
                else if (countB > 0)
                {
                    A[i] = 2;
                    countB--;
                }
            }
            return A;
        }
    }
}
