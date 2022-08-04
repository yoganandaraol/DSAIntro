/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
    Given an array A and an integer B. 
    A pair(i, j) in the array is a good pair if i != j and (A[i] + A[j] == B). 
    Check if any good pair exist or not. 
 * 
 * ####################################################################
 */

using System;

namespace _010_GoodPairOfSumExists
{
    class Program
    {
        static void Main(string[] args)
        {
            string nString = Console.ReadLine();
            int n = int.Parse(nString);
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.TryParse(Console.ReadLine().Trim(), out int result) ? result : 0;
            }
            int b = int.Parse(Console.ReadLine().Trim());
            if (CheckGoodPairOfSumExists(arr, b))
                Console.WriteLine("True");
            else Console.WriteLine("False");
        }

        static bool CheckGoodPairOfSumExists(int[] A, int B)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    //if (A[i] + A[j] == B)
                    //    return true;

                    Console.WriteLine(string.Format("({0},{1})", i, j));
                }
            }
            return false;
        }
    }
}
