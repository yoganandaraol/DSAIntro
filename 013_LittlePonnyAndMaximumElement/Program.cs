
/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
    Little Ponny is given an array, A, of N integers. 
    In a particular operation, he can set any element of the array equal to -1.

    He wants your help in finding out the minimum number of operations required such that 
    the maximum element of the resulting array is B. If it is not possible, then return -1.

    Problem Constraints
    -------------------
        1 <= |A| <= 10^5
        1 <= A[i] <= 10^9


    Sample Input 1:
    ------------
     A = [2, 4, 3, 1, 5]
     B = 3 

    Sample Output 1:
    -------------
    2 


    Sample Input 2:
    ------------
    A = [1, 4, 2]
    B = 3 

    Sample Output 2:
    -------------
    -1

 * 
 * ####################################################################
 */


using System;
using System.Collections.Generic;

namespace _013_LittlePonnyAndMaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int solve(List<int> A, int B)
        {
            int count = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] == B)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                count = 0;
                for (int i = 0; i < A.Count; i++)
                {
                    if (A[i] > B)
                    {
                        count++;
                    }
                }
            }
            return count > 0 ? count : -1;
        }
    }
}
