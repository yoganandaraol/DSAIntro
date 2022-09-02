using System;

namespace _100_PrintNaturalNumberRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNaturalNumber(5);
            Console.WriteLine("---------------------");
            PrintNaturalNumber2(5);
            Console.WriteLine("---------------------");
            Console.WriteLine(IsPalindrome("malayalam", 0, 8)   == 1 ? "Passed":"Failed");
            Console.WriteLine("---------------------");
            Console.WriteLine(IsPalindrome("malayyalam", 0, 9)  == 1 ? "Passed":"Failed");
            Console.WriteLine("---------------------");
            Console.WriteLine(IsPalindrome("malayayalam", 0, 9) == 0 ? "Passed":"Failed");
            Console.WriteLine("---------------------");
            Console.WriteLine(IsPalindrome("malayayalam", 0, 10)== 1 ? "Passed":"Failed");
            Console.WriteLine("---------------------");
            Console.WriteLine(IsPalindrome("malayayalaa", 0, 10) == 0 ? "Passed" : "Failed");
            Console.WriteLine("---------------------");
            Console.WriteLine(IsPalindrome("malayaaalam", 0, 10) == 0 ? "Passed" : "Failed");
            Console.WriteLine("---------------------");
            Console.WriteLine(CheckPalindrome("malayaalam", 0, 9) == 0 ? "Passed" : "Failed");


            Console.WriteLine("---------------------");
            Console.WriteLine("---------------------");
            Console.WriteLine(IsPalindromeV1("malayalam", 0, 8) == 1 ? "Passed" : "Failed");
            Console.WriteLine(IsPalindromeV1("malayyalam", 0, 9) == 1 ? "Passed" : "Failed");
            Console.WriteLine(IsPalindromeV1("malayayalam", 0, 9) == 0 ? "Passed" : "Failed");
            Console.WriteLine(IsPalindromeV1("malayayalam", 0, 10) == 1 ? "Passed" : "Failed");
            Console.WriteLine(IsPalindromeV1("malayayalaa", 0, 10) == 0 ? "Passed" : "Failed");
            Console.WriteLine(IsPalindromeV1("malayaaalam", 0, 10) == 0 ? "Passed" : "Failed");
        }

        static void PrintNaturalNumber(int n)
        {
            if (n == 1)
            {
                Console.WriteLine(1);
                return;
            }
            PrintNaturalNumber(n - 1);
            Console.WriteLine(n);
        }

        // Wrong answer
        static void PrintNaturalNumber2(int n)
        {
            if (n == 1)
            {
                Console.WriteLine(1);
                return;
            }
            Console.WriteLine(n);
            PrintNaturalNumber(n - 1);

        }

        static int IsPalindrome(string s, int lIndex, int rIndex)
        {
            if (lIndex == rIndex)
                return 1;
            else if (lIndex + 1 == rIndex && s[lIndex] == s[rIndex])
                return 1;
            else
                if (s[lIndex] != s[rIndex])
                    return 0;

            return IsPalindrome(s, lIndex + 1, rIndex - 1);
        }

        static int IsPalindromeV1(string s, int lIndex, int rIndex)
        {
            if (lIndex >= rIndex)
                return 1;
                
            if (s[lIndex] != s[rIndex])
                return 0;

            return IsPalindrome(s, lIndex + 1, rIndex - 1);
        }

        static int CheckPalindrome(string A, int i, int j)
        {
            if (i >= j)
                return 1;
            if (A[i] == A[j])
                return CheckPalindrome(A, i + 1, j - 1);

            return 0;
        }
    }
}
