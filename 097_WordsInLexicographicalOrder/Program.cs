using System;
using System.Collections.Generic;
using System.Linq;

namespace _097_WordsInLexicographicalOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputA = new List<string> { "hello", "scaler", "interviewbit" };
            string B = "adhbcfegskjlponmirqtxwuvzy";
            Console.WriteLine(WordsInLexicographicalOrderV1(inputA, B) == 1 ? "Passed" : "Failed");

            inputA = new List<string> { "fine", "none", "no" };
            B = "qwertyuiopasdfghjklzxcvbnm";
            Console.WriteLine(WordsInLexicographicalOrderV1(inputA, B) == 0 ? "Passed" : "Failed");

            inputA = new List<string> { "hello", "leetcode" };
            B = "hlabcdefgijkmnopqrstuvwxyz";
            Console.WriteLine(WordsInLexicographicalOrderV1(inputA, B) == 1 ? "Passed" : "Failed");

            inputA = new List<string> { "word", "world", "row" };
            B = "worldabcefghijkmnpqstuvxyz";
            Console.WriteLine(WordsInLexicographicalOrderV1(inputA, B) == 0 ? "Passed" : "Failed");

            inputA = new List<string> { "apple", "app" };
            B = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine(WordsInLexicographicalOrderV1(inputA, B) == 0 ? "Passed" : "Failed");

            inputA = new List<string> { "ipial", "qjqgt", "vfnue", "vjqfp", "eghva", "ufaeo", "atyqz", "chmxy", "ccvgv", "ghtow" };
            B = "nbpfhmirzqxsjwdoveuacykltg";
            Console.WriteLine(WordsInLexicographicalOrderV1(inputA, B) == 1 ? "Passed" : "Failed");



            inputA = new List<string> { "hello", "scaler", "interviewbit" };
            B = "adhbcfegskjlponmirqtxwuvzy";
            Console.WriteLine(WordsInLexicographicalOrder(inputA, B) == 1 ? "Passed" : "Failed");

            inputA = new List<string> { "fine", "none", "no" };
            B = "qwertyuiopasdfghjklzxcvbnm";
            Console.WriteLine(WordsInLexicographicalOrder(inputA, B) == 0 ? "Passed" : "Failed");

            inputA = new List<string> { "hello", "leetcode" };
            B = "hlabcdefgijkmnopqrstuvwxyz";
            Console.WriteLine(WordsInLexicographicalOrder(inputA, B) == 1 ? "Passed" : "Failed");

            inputA = new List<string> { "word", "world", "row" };
            B = "worldabcefghijkmnpqstuvxyz";
            Console.WriteLine(WordsInLexicographicalOrder(inputA, B) == 0 ? "Passed" : "Failed");

            inputA = new List<string> { "apple", "app" };
            B = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine(WordsInLexicographicalOrder(inputA, B) == 0 ? "Passed" : "Failed");

            inputA = new List<string> { "ipial", "qjqgt", "vfnue", "vjqfp", "eghva", "ufaeo", "atyqz", "chmxy", "ccvgv", "ghtow" };
            B = "nbpfhmirzqxsjwdoveuacykltg";
            Console.WriteLine(WordsInLexicographicalOrder(inputA, B) == 1 ? "Passed" : "Failed");
        }

        static int WordsInLexicographicalOrder(List<string> A, string B)
        {
            int n = A.Count;
            int[] index = new int[26];
            for (int i = 0; i < B.Length; i++)
            {
                index[(int)B[i] - (int)'a'] = i;
            }
            for (int i = 0; i < A.Count - 1; i++)
            {
                string word1 = A[i], word2 = A[i + 1];
                int flag = 0;
                for (int k = 0; k < Math.Min(word1.Length, word2.Length); k++)
                {
                    if (word1[k] != word2[k])
                    {
                        if (index[(int)word1[k] - (int)'a'] > index[(int)word2[k] - (int)'a'])
                            return 0;
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    if (word1.Length > word2.Length)
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }

        static int WordsInLexicographicalOrderV1(List<string> A, string B)
        {
            var lexOrderChars = B.ToCharArray();

            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; i < A.Count - 1 && j < A[i].Length; j++)
                {
                    if (j >= A[i + 1].Length)
                        return 0;

                    if (Array.IndexOf(lexOrderChars, A[i][j]) > Array.IndexOf(lexOrderChars, A[i + 1][j]))
                        return 0;
                    if (Array.IndexOf(lexOrderChars, A[i][j]) == Array.IndexOf(lexOrderChars, A[i + 1][j]))
                        continue;
                    else break;
                }
            }
            return 1;
        }
    }
}
