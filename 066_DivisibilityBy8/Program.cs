/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        You are given a number A in the form of a string. Check if the number is divisible by eight or not.

        Return 1 if it is divisible by eight else, return 0.

    Problem Constraints
    -------------------
        1 <= length of the String <= 100000
        '0' <= A[i] <= '9'

    Output Format
    -------------
        Return 1 if it is divisible by eight else return 0.

    Sample Input:
    ------------
        A = "16"

    Sample Output:
    -------------
        1

    Sample Input:
    ------------
        A = "123"

    Sample Output:
    -------------
        0


 * 
 * ####################################################################
 */
using System;

namespace _066_DivisibilityBy8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DivisibilityByEight("16") == 1 ? "Passed" : "Failed");
            Console.WriteLine(DivisibilityByEight("123") == 0 ? "Passed" : "Failed");
            Console.WriteLine(DivisibilityByEightV1("40897237111816995922805307737859413552091006514927603847883130124746756767426237849396480087733429432861339411285568084588535007444731") == 0 ? "Passed" : "Failed");
        }

        static int DivisibilityByEight(string A)
        {
            // This approach will not work for large values
            // Here the input string has many digits which cant be type casted to int or long
            int intA = Convert.ToInt32(A);
            int ans = (intA % 8 + 8) % 8; // this will allow -ve value modulus also
            return ans == 0 ? 1 : 0;
        }

        static int DivisibilityByEightV1(string A)
        {
            /*
             * 
             * According to the divisibility rule of 8, 
             *      if the last three digits of a given number are zeros or 
             *      if the number formed by the last three digits is divisible by 8, 
             * then such a number is divisible by 8
             * 
             */

            string subString;
            if (A.Length >= 3)
                subString = A.Substring(A.Length - 3, 3);
            else subString = A;
            int intA = Convert.ToInt32(subString);
            return intA % 8 == 0 ? 1 : 0;


        }
    }
}
