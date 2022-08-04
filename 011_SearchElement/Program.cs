/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
    You are given an integer T (number of test cases). 
    You are given array A and an integer B for each test case. 
    You have to tell whether B is present in array A or not.

    Problem Constraints
    -------------------
        1 <= T <= 10

        1 <= |A| <= 10^5

        1 <= A[i], B <= 10^9

    Sample Input:
    ------------
    1
    6 1 2 3 4 5 6
    4

    Sample Output:
    -------------
    1
 * 
 * ####################################################################
 */

using System;

namespace _011_SearchElement
{
    class Program
    {
        static void Main(string[] args)
        {
            string nStringTestCases = Console.ReadLine();
            int nTestCases = int.Parse(nStringTestCases.Trim());

            int iterations = 1;
            while (iterations <= nTestCases)
            {
                var nElementsString = Console.ReadLine().Trim().Split(' ');
                var arrSizeAndElements = Array.ConvertAll(nElementsString, Convert.ToInt32);
                int searchNum = int.Parse(Console.ReadLine().Trim());

                if (SearchItem(arrSizeAndElements, searchNum))
                    Console.WriteLine(1);
                else
                    Console.WriteLine(0);

                iterations++;
            }
            
        }

        static bool SearchItem(int[] arr, int searchNum)
        {
            // 0th element is size of the array
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == searchNum)
                    return true;
            }
            return false;
        }
    }
}
