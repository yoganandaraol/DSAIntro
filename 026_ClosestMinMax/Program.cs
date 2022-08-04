/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
    Given an array A, find the size of the smallest subarray such that 
    it contains at least one occurrence of the maximum value of the array
    and at least one occurrence of the minimum value of the array.

    Problem Constraints
    -------------------
        1 <= |A| <= 2000

    Sample Input:
    ------------
        A = [1, 3] ---> Ans - 2
    
    Sample Input:
    -------------
        A = [2] ---> Ans - 1
 * 
 * ####################################################################
 */


using System;
using System.Collections.Generic;

namespace _026_ClosestMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<int> { 1, 2, 3, 1, 3, 4, 6, 4, 6, 3, 5 }; // Ans = 4
            //var input = new List<int> { 1, 2, 3, 1, 3, 4, 6, 4, 6, 3, 7, 5}; // Ans  = 8
            //var input = new List<int> { 1, 2, 3, 1, 3, 4, 6, 4, 6, 3, 7, 8 }; // Ans  = 9
            //var input = new List<int> { 343, 291, 963, 165, 152 }; // Ans  = 3
            //var input = new List<int> { 343 }; // Ans  = 1
            //var input = new List<int> { 3, 3, 3, 3, 3, 3 }; // Ans  = 1

            Console.WriteLine(ClosestMinMax(input));
        }

        static int ClosestMinMax(List<int> A)
        {
            if (A.Count == 1) return 1;
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < A.Count; i++)
            {
                max = Math.Max(max, A[i]);
                min = Math.Min(min, A[i]);
            }

            if (min == max) return 1;

            int currentMinPos = int.MinValue;
            int currentMaxPos = int.MinValue;
            int leastSize = int.MaxValue;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] == min) currentMinPos = i;
                if (A[i] == max) currentMaxPos = i;

                if ((currentMinPos >= 0 && currentMaxPos >= 0))
                {
                    int currentSize = Math.Abs(currentMaxPos - currentMinPos) + 1;
                    leastSize = currentSize < leastSize ? currentSize : leastSize;
                }
            }
            return leastSize;
        }

        public int solve(List<int> A)
        {
            int min_Index = -1, max_Index = -1;
            int min_ele = int.MaxValue, max_ele = int.MinValue;

            int ans = int.MaxValue;
            for (int i = 0; i < A.Count; i++)
            {
                min_ele = Math.Min(min_ele, A[i]);
                max_ele = Math.Max(max_ele, A[i]);
            }

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] == min_ele) min_Index = Math.Max(min_Index, i);
                if (A[i] == max_ele) max_Index = Math.Max(max_Index, i);

                if (min_Index != -1 && max_Index != -1)
                {
                    int len = Math.Abs(max_Index - min_Index) + 1;
                    ans = Math.Min(ans, len);
                }

            }

            return ans;
        }
    }
}
