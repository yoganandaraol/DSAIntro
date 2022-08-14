/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Given two binary strings, return their sum (also a binary string).
    
    Example:
        a = "100"
        b = "11"
        Return a + b = "111".

 * 
 * ####################################################################
 */
using System;
using System.Text;

namespace _051_AddBinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddBinary("100", "11")); // 111
            Console.WriteLine(AddBinary("10011", "11")); // 10110
            Console.WriteLine(AddBinary("11","1")); // 100
        }

        static string AddBinary(string A, string B)
        {
            var result = new StringBuilder();
            int maxDigits = Math.Max(A.Length, B.Length);
            bool carry = false;

            for (int i = 0; i < maxDigits; i++)
            {
                int count_ones = 0;
                int currentAIndex = A.Length - 1 - i;
                int currentBIndex = B.Length - 1 - i;

                if (currentAIndex >= 0 && A[currentAIndex] == '1')
                    count_ones += 1;

                if (currentBIndex >= 0 && B[currentBIndex] == '1')
                    count_ones += 1;

                if (carry)
                    count_ones += 1;

                if (count_ones > 1)
                    carry = true;
                else carry = false;

                if (count_ones % 2 == 0)
                    result.Insert(0, "0");
                else result.Insert(0, "1");
            }
            if (carry) result.Insert(0, "1");

            return result.ToString();
        }
    }
}
