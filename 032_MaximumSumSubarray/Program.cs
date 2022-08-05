using System;
using System.Collections.Generic;

namespace _032_MaximumSumSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<int> { 1, 2, 4, 4, 5, 5, 5, 7, 5 };
            Console.WriteLine(MaxSumSubArray(9, 14, input));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"> Array C Size </param>
        /// <param name="B"> Sum of Sub Array limit </param>
        /// <param name="C"> Array </param>
        /// <returns>
        /// returns the maximum sum of sub array <= B of size A from the Array C
        /// </returns>
        static int MaxSumSubArray(int A, int B, List<int> C)
        {
            if (C.Count == 1)
            {
                if (C[0] <= B)
                    return C[0];
                else return 0;
            }
            else
            {
                int maxSum = 0;
                for (int i = 0; i < C.Count; i++)
                {
                    int subTotal = 0;
                    for (int j = i; j < C.Count; j++)
                    {
                        subTotal += C[j];
                        if (subTotal <= B & subTotal > maxSum)
                            maxSum = subTotal;
                    }
                }
                return maxSum;
            }
        }
    }
}
