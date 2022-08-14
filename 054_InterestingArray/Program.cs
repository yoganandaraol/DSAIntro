/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        You have an array A with N elements. We have two types of operation available on this array :
        We can split an element B into two elements, C and D, such that B = C + D.
        We can merge two elements, P and Q, to one element, R, such that R = P ^ Q i.e., XOR of P and Q.
        
        You have to determine whether it is possible to convert array A to size 1, 
        containing a single element equal to 0 after several splits and/or merge?

    Problem Constraints
    -------------------
        1 <= N <= 100000
        1 <= A[i] <= 10^6

    Output Format
    -------------
        Return "Yes" if it is possible otherwise return "No".

    Sample Input:
    ------------
        A = [9, 17]

    Sample Output:
    -------------
        Yes
        Explanation:
            Following is one possible sequence of operations -  
             1) Merge i.e 9 XOR 17 = 24  
             2) Split 24 into two parts each of size 12  
             3) Merge i.e 12 XOR 12 = 0  
             As there is only 1 element i.e 0. So it is possible.

    Sample Input:
    ------------
         A = [1]

    Sample Output:
    -------------
        No
        Explanation:
            There is no possible way to make it 0.
 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;

namespace _054_InterestingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = new List<int> { 9, 17 };
            Console.WriteLine(CovertArrayToSizeOne(inputA) == "Yes" ? "Passed" : "Failed");
            inputA = new List<int> { 1 };
            Console.WriteLine(CovertArrayToSizeOne(inputA) == "No" ? "Passed" : "Failed");
            inputA = new List<int> { 0 };
            Console.WriteLine(CovertArrayToSizeOne(inputA) == "Yes" ? "Passed" : "Failed");
            inputA = new List<int> { 100, 199, 201, 1000001 };
            Console.WriteLine(CovertArrayToSizeOne(inputA) == "No" ? "Passed" : "Failed");
            inputA = new List<int> { 1234, 2342, 3452345, 23452, 9564 };
            Console.WriteLine(CovertArrayToSizeOne(inputA) == "No" ? "Passed" : "Failed");
            inputA = new List<int> { 1234, 2342, 345234, 23452, 9564 };
            Console.WriteLine(CovertArrayToSizeOne(inputA) == "No" ? "Passed" : "Failed");
        }

        static string CovertArrayToSizeOne(List<int> A)
        {
            int ans = 0;
            for (int i = 0; i < A.Count; i++)
                ans ^= A[i];
            
            if ((ans & 1) == 0)
                return "Yes";

            return "No";
        }
    }
}
