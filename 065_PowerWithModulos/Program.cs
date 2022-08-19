/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        You are given A, B and C .
        Calculate the value of (A ^ B) % C

    Problem Constraints
    -------------------
        1 <= A <= 10^9
        0 <= B <= 10^5
        1 <= C <= 10^9

    Output Format
    -------------
        Return an integer.

    Sample Input:
    ------------
        A = 2
        B = 3
        C = 3

    Sample Output:
    -------------
        2

        Explanation:
            (2 ^ 3) % 3 = 8 % 3 = 2

    Sample Input:
    ------------
        A = 5
        B = 2
        C = 4

    Sample Output:
    -------------
        1
        
        Explanation:
            (5 ^ 2) % 4 = 25 % 4 = 1
 * 
 * ####################################################################
 */

using System;

namespace _065_PowerWithModulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PowerWithModulo(2,3,3) == 2 ? "Passed" : "Failed");
            Console.WriteLine(PowerWithModulo(5,2,4) == 1 ? "Passed" : "Failed");
            Console.WriteLine(PowerWithModuloV1(76277, 376, 2417) == 2254 ? "Passed" : "Failed");
            Console.WriteLine(PowerWithModuloV2(76277, 376, 2417) == 2254 ? "Passed" : "Failed");
            Console.WriteLine(PowerWithModuloV2(55711, 284, 64649) == 45880 ? "Passed" : "Failed");
            Console.WriteLine(PowerWithModuloV3(55711, 284, 64649) == 45880 ? "Passed" : "Failed");
        }

        static int PowerWithModulo(int A, int B, int C)
        {
            // Approach  causes overflow
            int result = 0;
            long longA = A;
            //  (A ^ B) % C = (A % C) ^ B
            result = Convert.ToInt32(Math.Pow(longA % C, B)) % C;
            return result;
        }

        static int PowerWithModuloV1(int A, int B, int C)
        {
            int result = 1;
            for (int i = 0; i < B; i++)
            {
                result = (result * A) % C;
            }
            return result;
        }

        static long PowerWithModuloV2(int A, int B, int C)
        {
            long result = 1;
            //  (A ^ B) % C = (A % C) ^ B
            for (int i = 0; i < B; i++)
                result = (result * A % C);
            return result;
        }

        static long PowerWithModuloV3(int A, int B, int C)
        {
            long result = 1;
            A %= C;
            for (int i = 0; i < B; i++)
                result = (result * A) % C;
            return result;
        }
    }
}
