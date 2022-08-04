/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
    Given an array of size N, find the subarray of size K with the least average.

    Problem Constraints
    -------------------
        1 <= k <= N <= 1e5
        -1e5 <= A[i] <= 1e5

    Sample Input:
    ------------
        A = [3, 7, 90, 20, 10, 50, 40]
        B = 3
    
    Sample Output:
    -------------
        Subarray between indexes 3 and 5
        The subarray {20, 10, 50} has the least average 
        among all subarrays of size 3.
        Average of the elements is (20+10+50)/3 = 80/3 = 26
 * 
 * ####################################################################
 */


using System;
using System.Collections.Generic;

namespace _031_SubArraysWithLeastAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            //var inputA = new List<int> { 3, 7, 90, 20, 10, 50, 40 }; // Ans - 26
            var inputB = 3;
            //var inputA = new List<int> { 20, 3, 13, 5, 10, 14, 8, 5, 11, 9, 1, 11  }; // index = 3 has least average
            //inputB = 9;
            var inputA = new List<int> { 18, 11, 16, 19, 11, 9, 8, 15, 3, 10, 9, 20, 1, 19 }; // Index = 12
            inputB = 1;


            Console.WriteLine(LeastAverageOfSubArraysV1(inputA, inputB));
        }

        /// <summary>
        /// Bruteforce approach
        /// </summary>
        /// <param name="A"> integer array A of size N</param>
        /// <param name="B"> sub array size </param>
        /// <returns> 
        ///     returns least average of sub array
        ///     avg = (sum of sub array) / (sub array size)
        /// </returns>
        static int LeastAverageOfSubArrays(List<int> A, int B)
        {
            int leastAvg = int.MaxValue;

            /*
             *  Sub array of size - B
             *  Size of array A - N
             *  
             *  So last sub array starting index will be (N-K)
             *  
             *  first for loop runs for N-K+1 times
             *  second for loop runs for K times
             *  
             *  So the total iterations = (N-K+1) * K = N*K + K^2 + K = N*K
             *  Based on condition, N >= K
             *      TC = O(N*K)
             *      SC = O(1)
             */

            for (int i = 0; i < A.Count - B; i++)
            {
                int sumSubArray = 0;
                for (int j = i; j < i + B; j++)
                {
                    sumSubArray += A[j];
                }
                leastAvg = Math.Min(sumSubArray / B, leastAvg);
            }

            return leastAvg;
        }

        /// <summary>
        /// Sliding approach
        /// </summary>
        /// <param name="A"> integer array A of size N</param>
        /// <param name="B"> sub array size </param>
        /// <returns> 
        ///     returns least average of sub array
        ///     avg = (sum of sub array) / (sub array size)
        /// </returns>
        static int LeastAverageOfSubArraysV1(List<int> A, int B)
        {
            int leastIndex = A.Count;

            /*
             *  Sub array of size - B
             *  Size of array A - N
             *  
             *  Using sliding approach
             *  
             *  Observations:
             *      First Sub Array index starts from 0 to K-1
             *      Second Sub Array index starts from 1 to k
             *      ...
             *      ...
             *      Last Sub Array index starts from N-K+3 to N-K+1
             *      
             *  Prefix Sum Iterations = N
             *  Sum of arrays iterations = B + N - B = N
             *      So total    TC = O(N + N) = O(N)
             *                  SC = O(1);
             *  
             */

            // Prefix Sum -- N iterations
            for (int i = 1; i < A.Count; i++)
            {
                A[i] = A[i - 1] + A[i];
            }

            // Sum of sub arrays iterations = B + N - B = N iterations
            long sumSubArray = A[B - 1];
            long leastSum = sumSubArray;
            leastIndex = 0;

            Console.WriteLine(sumSubArray);

            for (int i = 1; i < A.Count - B + 1; i++)
            {
                sumSubArray = 0;
                sumSubArray += A[i + B - 1] - A[i - 1];
                Console.WriteLine(sumSubArray);
                if (leastSum > sumSubArray)
                {
                    leastSum = sumSubArray;
                    leastIndex = i;
                }
            }

            return leastIndex;
        }
    }
}
