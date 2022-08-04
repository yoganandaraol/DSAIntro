/*
 *  Q --> given an integer array  A, count the number of leaders in the array
 *      Leader --> An element which is greater than all  elements on right of it.
 *      Note : A[N-1] is always leader
 *  
 *  Ex:
 *      A = [15, -1, 7, 2, 5, 4, -2, 3] Ans = 5
 *      
 *      Leader = A[i] if A[i] is greater than from A[i+1] to A[N-1]
 
    Bruteforce approach:
        for all i check if A[i] > max element of right

 */
using System;
using System.Collections.Generic;

namespace _019_LeadersOfTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfLeaders(new int[] { 15, -1, 7, 2, 5, 4, -2, 3 }));
        }

        static int NumberOfLeaders(int[] a)
        {
            // bruteforce approach
            // TC = O(N^2) 
            // SC = O(1)

            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {

                }
            }

            // Array Carry Forward Approach
            // TC = O(N) 
            // SC = O(1)

            // For subarray is there a minimum size limit applied.

            int result = 1;
            int max = a[a.Length - 1];
            var leaderItems = new List<int>(); // To populate leader items
            for (int i = a.Length -2 ; i>=0; i--)
            {
                if (a[i] > max)
                {
                    result += 1;
                    max = a[i];
                    leaderItems.Add(max);
                }
            }
            return result;
        }
    }
}
