
/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Given three 2-digit integers, A, B, and C, find out the minimum number obtained by concatenating them in any order.
        Return the minimum result obtained.

    Problem Constraints
    -------------------
        10 <= A, B, C <= 99

    Input Format:
    -------------
        The first argument of input contains an integer, A.
        The second argument of input contains an integer, B.
        The third argument of input contains an integer, C.

    Output Format
    -------------
        Return an integer representing the answer.

    Sample Input:
    ------------
        A = 10
        B = 20
        C = 30

    Sample Output:
    -------------
        102030 

    Sample Input:
    ------------
        A = 55
        B = 43
        C = 47 

    Sample Output:
    -------------
        434755 
        
 * 
 * ####################################################################
 */
using System;

namespace _068_PossibleLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargestNumber(10, 20, 30) == 102030 ? "Passed" : "Failed");
            Console.WriteLine(LargestNumber(55, 21, 46) == 214655 ? "Passed" : "Failed");
        }

        static int LargestNumber(int A, int B, int C)
        {
            int min = Math.Min(Math.Min(A, B), C);
            int max = Math.Max(Math.Max(A, B), C);
            int temp = A + B + C - (min + max);

            return int.Parse(String.Format("{0}{1}{2}", min, temp, max));
        }

        public int LargestNumberV1(int A, int B, int C)
        {
            if (A <= B && B <= C)
                return A * 10000 + B * 100 + C;
            else if (A <= C && C <= B)
                return A * 10000 + C * 100 + B;
            else if (B <= A && A <= C)
                return B * 10000 + A * 100 + C;
            else if (B <= C && C <= A)
                return B * 10000 + C * 100 + A;
            else if (C <= A && A <= B)
                return C * 10000 + A * 100 + B;
            else
                return C * 10000 + B * 100 + A;
        }
    }
}
