/*
 *  Problem Description
        Given an array, arr[] of size N, the task is to find the count of array indices such that 
        removing an element from these indices makes the sum of even-indexed and odd-indexed array elements equal.
 * 
 *  
 *  Problem Constraints
 *       1 <= n <= 10^5
 *       -10^5 <= A[i] <= 10^5
 *       
 *  Test Case Input:
 *  
 *  Input 1:
        A=[2, 1, 6, 4]
        Ans - 1
 *  
 *  Input 2:
        A=[1, 1, 1]
 *      Ans - 3
 *      
 *  
 */

using System;
using System.Collections.Generic;

namespace _022_SumOfEvenOddIndexedElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = new List<int> { 1, 2, 3, 7, 1, 2, 3 };
            //var inputList = new List<int> { 2, 1, 6, 4 };
            //var inputList = new List<int> { 1, 1, 1 };
            Console.WriteLine(MagicalEvenOddIndexedElementsV1(inputList));
        }

        static int MagicalEvenOddIndexedElements(List<int> A)
        {
            int arrSize = A.Count;
            int count = 0;
            for (int i = 0; i < arrSize; i++)
            {
                var tempLst = new List<int>(A);
                tempLst.RemoveAt(i);
                int tempEvenSum = 0;
                int tempOddSum = 0;
                for (int j = 0; j < tempLst.Count; j++)
                {
                    if (j % 2 == 0)
                        tempEvenSum += tempLst[j];
                    else
                        tempOddSum += tempLst[j];
                }

                if (tempEvenSum == tempOddSum) count++;
            }
            return count;
        }

        static int MagicalEvenOddIndexedElementsV1(List<int> A)
        {
            /*
             *      TC = O(N+N) = O(N)
             *      SC = O(N)
             * 
             */
            int arrSize = A.Count;
            int count = 0;

            int maxEvenIndex = arrSize % 2 == 0 ? arrSize - 2 : arrSize - 1;
            int maxOddIndex = arrSize % 2 == 0 ? arrSize - 1 : arrSize - 2;

            var lstEvenOddSum = new List<int>(A);

            for (int i = 2; i < arrSize; i++)
            {
                if (i % 2 == 0)
                {
                    lstEvenOddSum[i] += lstEvenOddSum[i - 2];
                }
                else
                {
                    lstEvenOddSum[i] += lstEvenOddSum[i - 2];
                }
            }
            int totalEvenSum = lstEvenOddSum[maxEvenIndex];
            int totalOddSum = lstEvenOddSum[maxOddIndex];
            for (int i = 0; i < arrSize; i++)
            {
                int tempEvenSum = 0;
                int tempOddSum = 0;
                if (i == 0)
                {
                    tempEvenSum = totalOddSum;
                    tempOddSum = totalEvenSum - lstEvenOddSum[0];
                }
                else if (i == 1)
                {
                    tempEvenSum = lstEvenOddSum[i - 1] + totalOddSum - lstEvenOddSum[1];
                    tempOddSum = totalEvenSum - lstEvenOddSum[0];
                }
                else if (i % 2 == 0)
                {
                    tempEvenSum = lstEvenOddSum[i - 2] + totalOddSum - lstEvenOddSum[i - 1];
                    tempOddSum = lstEvenOddSum[i - 1] + totalEvenSum - lstEvenOddSum[i];
                }
                else
                {
                    tempEvenSum = lstEvenOddSum[i - 1] + totalOddSum - lstEvenOddSum[i];
                    tempOddSum = lstEvenOddSum[i - 2] + totalEvenSum - lstEvenOddSum[i - 1];
                }

                if (tempEvenSum == tempOddSum) count++;
            }
            return count;
        }
    }
}
