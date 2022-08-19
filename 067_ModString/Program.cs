/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        You are given a large number in the form of a string A where each character denotes a digit of the number.
        You are also given a number B. You have to find out the value of A % B and return it.

    Problem Constraints
    -------------------
        1 <= A.length() <= 10^5
        0 <= Ai <= 9
        1 <= B <= 10^9

    Output Format
    -------------
        Return a single integer denoting the value of A % B.

    Sample Input:
    ------------
        A = "143"
        B = 2

    Sample Output:
    -------------
        1

        Explanation:
            143 is an odd number so 143 % 2 = 1.

    Sample Input:
    ------------
        A = "43535321"
        B = 47

    Sample Output:
    -------------
        20
        
        Explanation:
            43535321 % 47 = 20
 * 
 * ####################################################################
 */

using System;

namespace _067_ModString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindModV2("143", 2) == 1 ? "Passed" : "Failed");
            Console.WriteLine(FindModV2("43535321", 47) == 20 ? "Passed" : "Failed");
            Console.WriteLine(FindModV2("43535321", 470) == 161 ? "Passed" : "Failed");
            Console.WriteLine(FindMod("43535321", 470) == 161 ? "Passed" : "Failed");
        }

        static int FindMod(string A, int B)
        {
            int ans = 0;

            for (int i = A.Length-1; i >= 0; i--)
            {
                ans += (int.Parse(A[i].ToString()) * Convert.ToInt32(Math.Pow(10, A.Length - i - 1) % B)) % B;
            }
            return ans % B;
        }

        static int FindModV1(string A, int B)
        {
            long pMod = 0, power = 1;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                pMod = (pMod + (A[i] - '0') * power) % B;
                power = (power * 10) % B;
            }
            return (int)pMod % B;
        }

        static int FindModV2(string A, int B)
        {
            long modResult = 0, power = 1;
            int nDigits = A.Length;
            for (int i = nDigits - 1; i >= 0; i--)
            {
                int digit = A[i] - '0';
                modResult = (modResult + digit * power) % B;
                power = (power * 10) % B;
            }
            return (int)modResult % B;
        }
    }
}
