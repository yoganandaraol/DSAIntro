/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Write a program to input an integer T and then for each test case input two integers A and B in two different lines and 
        then print T lines containing Least Common Multiple (LCM) of two given 2 numbers A and B.

        LCM of two integers is the smallest positive integer divisible by both.

    Problem Constraints
    -------------------
        1 <= T <= 1000
        1 <= A,B <= 1000

    Input Format
    ------------
        In first-line input T which means number of test cases.

        Next 2T lines contains input A and B for each testcase.
        First line of each testcase contain an integer A and second line of the testcase contains input B.

    Output Format
    -------------    
        T lines each containing an integer representing LCM of A & B.

    Sample Input:
    ------------
        3
        2
        3
        9
        6
        2
        6

    Sample Output:
    -------------
        6
        18
        6

 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;

namespace _070_LeastCommonMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int nTestCases = int.Parse(Console.ReadLine());
            var dataTestCases = new List<int>();
            for (int i = 0; i < 2*nTestCases; i++)
                dataTestCases.Add(int.Parse(Console.ReadLine()));

            for (int i = 0; i < nTestCases; i++)
            {
                int a = dataTestCases[2 * i];
                int b = dataTestCases[2 * i + 1];

                int l = a > b ? a : b;
                int s = a < b ? a : b;

                int j = 1;
                while (l * j % s > 0)
                    j++;

                Console.WriteLine(l * j);
            }
        }
    }
}
