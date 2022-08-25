using System;
using System.Collections.Generic;
using System.Linq;

namespace _082_ChangeCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinNumOfDistinctChars("abcabbccd", 3) == 2 ? "Passed" : "Failed");
            Console.WriteLine(MinNumOfDistinctChars("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcd", 88) == 4 ? "Passed" : "Failed");
            Console.WriteLine(MinNumOfDistinctChars("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcd", 4) == 25 ? "Passed" : "Failed");
            Console.WriteLine(MinNumOfDistinctChars("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcd", 5) == 25 ? "Passed" : "Failed");
            Console.WriteLine(MinNumOfDistinctChars("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcd", 12) == 23 ? "Passed" : "Failed");
        }

        // With List
        static int MinNumOfDistinctChars(string A, int B)
        {
            var freqs = new List<int>();
            freqs.AddRange(Enumerable.Repeat(0, 26));
            for (int i = 0; i < A.Length; i++)
                freqs[A[i] - 'a'] += 1;

            freqs.Sort();
            int count = freqs[0] > 0 && freqs[0] <= B ? 1 : 0;
            for (int i = 1; i < 26; i++)
            {
                freqs[i] += freqs[i - 1];
                if (freqs[i]> 0 && freqs[i] <= B)
                    count++;
            }

            var distictCharsA = A.ToCharArray().Distinct().ToArray();

            return distictCharsA.Length - count;
        }

        // With Array
        static int MinNumOfDistinctCharsV1(string A, int B)
        {
            var freqs = new int[26];
            for (int i = 0; i < A.Length; i++)
                freqs[A[i] - 'a'] += 1;

            Array.Sort(freqs);
            int count = freqs[0] > 0 && freqs[0] <= B ? 1 : 0;
            for (int i = 1; i < 26; i++)
            {
                freqs[i] += freqs[i - 1];
                if (freqs[i] > 0 && freqs[i] <= B)
                    count++;
            }

            var distictCharsA = A.ToCharArray().Distinct().ToArray();

            return distictCharsA.Length - count;
        }

        public int solve(string A, int B)
        {
            int n = A.Length;
            int[] arr = new int[26];
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                arr[(int)A[i] - (int)'a']++;
                if (arr[(int)A[i] - (int)'a'] == 1)
                {
                    ans++;
                }
            }
            Array.Sort(arr);
            for (int i = 0; i < 26; i++)
            {
                if (B - arr[i] >= 0 && arr[i] != 0)
                {
                    ans--;
                    B -= arr[i];
                }
            }

            return ans;
        }
    }
}
