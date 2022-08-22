
/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Given an integer array A of size N. You can remove any element from the array in one operation.
        The cost of this operation is the sum of all elements in the array present before this operation.

        Find the minimum cost to remove all elements from the array.

    Problem Constraints
    -------------------
        0 <= N <= 1000
        1 <= A[i] <= 10^3

    Output Format
    -------------
        Return an integer denoting the total cost of removing all elements from the array.

    Sample Input:
    ------------
        A = [2, 1]

    Sample Output:
    -------------
        4

        Explanation:
             Given array A = [2, 1]
             Remove 2 from the array => [1]. Cost of this operation is (2 + 1) = 3.
             Remove 1 from the array => []. Cost of this operation is (1) = 1.
             So, total cost is = 3 + 1 = 4.

    Sample Input:
    ------------
        A = [5]

    Sample Output:
    -------------
        5
        
        Explanation:
            There is only one element in the array. So, cost of removing is 5.
 * 
 * ####################################################################
 */
using System;
using System.Collections.Generic;

namespace _076_ElementsRemoval
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = new List<int> { 2, 1 };
            Console.WriteLine(MinCostElementRemoval(inputA) == 4 ? "Passed" : "Failed");
            inputA = new List<int> { 5 };
            Console.WriteLine(MinCostElementRemoval(inputA) == 5 ? "Passed" : "Failed");
        }

        static int MinCostElementRemoval(List<int> A)
        {
            int ans = 0;
            if (A.Count == 1) return A[0];
            
            A.Sort((a, b) => b.CompareTo(a));
            for (int i = 0; i < A.Count; i++)
            {
                ans += A[i] * (i + 1);
            }

            return ans;
        }
    }
}
