/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
    Given an integer array A of size N and an integer B, 
    you have to print the same array after rotating it B times 
    towards the right.

    Problem Constraints
    -------------------
        1 <= N <= 10^6
        1 <= A[i] <=10^8
        1 <= B <= 10^9

    Sample Input:
    ------------
    6 1 2 3 4 5 6
    2

    Sample Output:
    -------------
    5 6 1 2 3 4
 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;

namespace _008_RotationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var nElementsString = Console.ReadLine().Trim().Split(' ');
            var arrSizeAndElements = Array.ConvertAll(nElementsString, Convert.ToInt32);
            var arrElements = new int[arrSizeAndElements[0]];
            int shiftNum = int.Parse(Console.ReadLine().Trim());
            if (shiftNum > arrElements.Length)
            {
                shiftNum %= arrElements.Length;
            }
            for (int i = 1; i < arrSizeAndElements.Length; i++)
            {
                arrElements[i - 1] = arrSizeAndElements[i];
            }

            //var finalArray = new List<int>();
            //finalArray.AddRange(arrSizeAndElements);
            //finalArray.RemoveAt(0);

            //ReverseArrayForSpecificIndex(finalArray, 0, finalArray.Count - 1);
            //ReverseArrayForSpecificIndex(finalArray, 0, shiftNum - 1);
            //ReverseArrayForSpecificIndex(finalArray, shiftNum, finalArray.Count - 1);

            ReverseArrayForSpecificIndex(arrElements, 0, arrElements.Length - 1);
            ReverseArrayForSpecificIndex(arrElements, 0, shiftNum - 1);
            ReverseArrayForSpecificIndex(arrElements, shiftNum, arrElements.Length - 1);

            for (int i = 0; i < arrElements.Length; i++)
            {
                Console.Write(arrElements[i].ToString() + " ");
            }
        }

        static void ReverseArrayForSpecificIndex(List<int> A, int lIndex, int rIndex)
        {
            while (lIndex < rIndex)
            {
                Swap(A, lIndex, rIndex);
                lIndex++;
                rIndex--;
            }
            //for (int i = lIndex; i < (lIndex + rIndex) / 2; i++)
            //{
            //    Swap(A, i, (lIndex + rIndex - i));
            //}

        }

        static void Swap(List<int> A, int lIndex, int rIndex)
        {
            int temp = A[lIndex];
            A[lIndex] = A[rIndex];
            A[rIndex] = temp;
        }

        static void ReverseArrayForSpecificIndex(int[] A, int lIndex, int rIndex)
        {
            while (lIndex < rIndex)
            {
                Swap(A, lIndex, rIndex);
                lIndex++;
                rIndex--;
            }
        }

        static void Swap(int[] A, int lIndex, int rIndex)
        {
            int temp = A[lIndex];
            A[lIndex] = A[rIndex];
            A[rIndex] = temp;
        }
    }
}
