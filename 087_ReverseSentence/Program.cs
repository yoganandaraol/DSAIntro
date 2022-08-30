using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _087_ReverseSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> inputA = new List<char> { 'I', ' ', 'l', 'o', 'v', 'e', ' ', 'S', 'c', 'a', 'l', 'e', 'r', ' ', 'a', 'c', 'a', 'd', 'e', 'm', 'y' };

            //var result = ReverseSentenceArray(inputA);
            var result = ReverseSentence("the sky is blue");
            Console.WriteLine(result);
        }

        static char[] ReverseSentenceArray(char[] A)
        {
            for (int i = 0; i < A.Length/2; i++)
            {
                Swap(A, i, A.Length - 1 - i);
            }

            int l = 0;
            for (int i = 0; i < A.Length-1; i++)
            {
                if (A[i] == ' ')
                {
                    ReverseArray(A, l, i);
                    l = i + 1;
                }
            }
            ReverseArray(A, l, A.Length - 1);
            return A;
        }

        static void Swap(char[] A, int lIndex, int rIndex)
        {
            char temp = A[lIndex];
            A[lIndex] = A[rIndex];
            A[rIndex] = temp;

        }

        public static void ReverseArray(char[] a, int l, int r)
        {
            for (int i = l; i < (r-l)/2; i++)
            {
                Swap(a, i, r - 1 - i);
            }
        }


        static string ReverseSentence(string A)
        {
            var wordArray = A.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            for (int i = wordArray.Length-1; i >= 0; i--)
            {
                if (i == 0) sb.Append(wordArray[i]);
                else sb.Append($"{wordArray[i]} ");
            }
            return sb.ToString();
        }
    }
}
