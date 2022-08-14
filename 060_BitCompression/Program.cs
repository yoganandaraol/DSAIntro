/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Richard Hendricks, a mastermind in compression algorithms, is an employee of Hooli in Silicon Valley.
        One day, he finally decided to quit and work on his new idea of the middle-out compression algorithm.

        He needed to work at the bit - level to compress data. He, eventually, encountered this problem.
        There is an array A of N integers. He has to perform certain operations on the elements.
        In any one operation, two indices i and j (i < j) are chosen, and A[i] is replaced with A[i] & A[j],
        and A[j] is replaced with A[i] | A[j], where & represents the Bitwise AND operation and | represents the Bitwise OR operation.
        This operation is performed over all the pairs of integers in the array.

        Help Richard find the Bitwise XOR of all the elements after performing the operations.

    Problem Constraints
    -------------------
        1 <=  N <= 10^5
        1 <= Ai <= 10^9

    Output Format
    -------------
        Return a single integer denoting the XOR of the elements after performing the operations.


    Sample Input:
    ------------
         A = [1, 3, 5]

    Sample Output:
    -------------
        7
        Explanation:
            After performing the operations, the array becomes [1, 1, 7].
            The XOR of all the elements of this array is 7.
            There can be other possible arrays, but we can prove that the XOR will always be 7.

    Sample Input:
    ------------
         A = [1, 1, 1]

    Sample Output:
    -------------
        1
        Explanation:
            Since all the elements are equal. 
            Even after applying the operations in any order, the array will be [1, 1, 1].
            The XOR of all the elements of this array is 1.
 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;

namespace _060_BitCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = new List<int>{ 1, 3, 5 };
            Console.WriteLine(CompressBitV1(inputA) == 7 ? "Passed" : "Failed");
            inputA = new List<int> { 1, 1, 1 };
            Console.WriteLine(CompressBitV1(inputA) == 1 ? "Passed" : "Failed");
        }

        static int CompressBit(List<int> A)
        {
            int result = 0;
            for (int i = 0; i < A.Count-1; i++)
            {
                int iItem = A[i];
                A[i] = iItem & A[i + 1];
                A[i + 1] = iItem | A[i + 1];
                result ^= A[i];
            }
            result ^= A[A.Count - 1];
            return result;
        }

        static int CompressBitV1(List<int> A)
        {
            // A[i] ^ A[j] = (A[i] & A[j]) ^ (A[i] | A[j])
            int result = 0;
            for (int i = 0; i < A.Count; i++)
            {
                result ^= A[i];
            }
            return result;
        }
    }
}
