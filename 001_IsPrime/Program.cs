/*

    Problem Description

    Given an integer A, you have to tell whether it is a prime number or not.
    A prime number is a natural number greater than 1 which is divisible only by 1 and itself.


    Problem Constraints
    1 <= A <= 10^6

    Input Format
    First and only line of the input contains a single integer A.

    Output Format
    Print YES if A is a prime, else print NO.

    Example Input

    Input 1:
    3 
    Input 2:
    4 

    Example Output

    Output 1:
    YES 
    Output 2:
    NO 

*/

using System;

namespace _001_IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string nString = Console.ReadLine();
            int n = int.Parse(nString);

            if (IsNumberPrime(n)) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }

        public static bool IsNumberPrime(int n)
        {
            int numberOfFactors = 0;
            for (int a = 1; a * a <= n; a++)
            {
                if (n % a == 0)
                {
                    if (a == n / a)
                        numberOfFactors += 1;
                    else
                        numberOfFactors += 2;
                }
            }
            return numberOfFactors <= 2;
        }
    }
}
