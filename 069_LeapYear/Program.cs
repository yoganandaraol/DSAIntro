

/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Given an integer A representing a year, Return 1 if it is a leap year else, return 0.

        A year is a leap year if the following conditions are satisfied:
            The year is multiple of 400.
            Else the year is multiple of 4 and not multiple of 100.

    Problem Constraints
    -------------------
        1 <= A <= 10^9

    Output Format
    -------------
        Return 1 if it is a leap year else return 0

    Sample Input:
    ------------
        A = 2020

    Sample Output:
    -------------
        1

    Sample Input:
    ------------
        A = 1999

    Sample Output:
    -------------
        0
 * 
 * ####################################################################
 */using System;

namespace _069_LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsLeapYear(2020) == 1 ? "Passed" : "Failed");
            Console.WriteLine(IsLeapYear(1999) == 0 ? "Passed" : "Failed");
            Console.WriteLine(IsLeapYear(2200) == 0 ? "Passed" : "Failed");
        }

        static int IsLeapYear(int A)
        {
            if (A % 400 == 0) return 1;
            else if (A % 4 == 0 && A % 100 > 0) return 1;
            else return 0;
        }
    }
}
