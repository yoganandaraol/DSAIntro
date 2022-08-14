/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Given an array of integers A, every element appears twice except for one. 
        Find that integer that occurs once.

        NOTE:   
            Your algorithm should have a linear runtime complexity. 
            Could you implement it without using extra memory?

    Problem Constraints
    -------------------
        2 <= |A| <= 2000000
        0 <= A[i] <= INTMAX

    Output Format
    -------------
        Return a single integer denoting the single element.

    Sample Input:
    ------------
         A = [1, 2, 2, 3, 1]

    Sample Output:
    -------------
        3

    Sample Input:
    ------------
         A = [1, 2, 2]

    Sample Output:
    -------------
        1
 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;

namespace _052_SoloNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = new List<int> { 1, 2, 2, -3, 1, 4,4 };

            //var result = FindSoloNumber(inputA);
            var result = FindSoloNumberUsingBinaryOper(inputA);

            Console.Write(result);

        }

        static int FindSoloNumber(List<int> A)
        {
            #region Time Consuming Approach
            //var resultantList = new List<int>();

            //for (int i = 0; i < A.Count; i++)
            //{
            //    if (resultantList.Contains(A[i]))
            //        resultantList.Remove(A[i]);
            //    else
            //        resultantList.Add(A[i]);
            //}
            #endregion
            //return resultantList.Count > 0 ? resultantList[0] : -1;

            /*
             * 
             *  Single Occurrance Element = uniqueItemsSum - (allItemsSum - uniqueItemsSum)
             *  
            */

            int allItemsSum = 0;
            var arrayUniqueItems = new HashSet<int>();
            foreach (var item in A)
            {
                arrayUniqueItems.Add(item);
                allItemsSum += item;
            }

            int uniqueItemsSum = 0;
            // Sum of Unique items 
            foreach (var item in arrayUniqueItems)
            {
                uniqueItemsSum += item;
            }

            var result = uniqueItemsSum - (allItemsSum - uniqueItemsSum);
            return result == 0 ? -1 : result;
        }


        static int FindSoloNumberUsingBinaryOper(List<int> A)
        {
            int num = 0;
            foreach (var item in A)
                num ^= item;

            return num;
        }

    }
}
