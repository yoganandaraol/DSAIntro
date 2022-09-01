using System;
using System.Collections.Generic;
using System.Linq;

namespace _094_LargestSubarraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputA = new List<int> { 1, 2, -2, 4, -4 };
            List<int> output = new List<int> { 2, -2, 4, -4 };
            Console.WriteLine(Enumerable.SequenceEqual(LargestSubarrySumZero(inputA), output) ? "Passed" : "Failed");
            //Console.WriteLine(LargestSubarrySumZeroLength(inputA) == 4 ? "Passed" : "Failed");

            inputA = new List<int> { 1, 2, -3, 3 };
            output = new List<int> { 1, 2, -3 };
            Console.WriteLine(Enumerable.SequenceEqual(LargestSubarrySumZero(inputA), output) ? "Passed" : "Failed");


            inputA = new List<int> { -19, 8, 2, -8, 19, 5, -2, -23 };
            output = new List<int> { };
            Console.WriteLine(Enumerable.SequenceEqual(LargestSubarrySumZero(inputA), output) ? "Passed" : "Failed");

            inputA = new List<int> { 0, 22, 7, 21, -11, -6, -7, -16, -2 };
            output = new List<int> { 0 };
            Console.WriteLine(Enumerable.SequenceEqual(LargestSubarrySumZero(inputA), output) ? "Passed" : "Failed");

            inputA = new List<int> { -1, 20, 7, -22, 1, 21, 5, 24, -26, -16, -4, -9, 19, 8, -27, 28, 9, 8, -29, 29, 8, 9, 17, -28, 13, 20, -1, -8, -16 };
            output = new List<int> { -1, 20, 7, -22, 1, 21, 5, 24, -26, -16, -4, -9, 19, 8, -27 };
            Console.WriteLine(Enumerable.SequenceEqual(LargestSubarrySumZero(inputA), output) ? "Passed" : "Failed");
        }

        static List<int> LargestSubarrySumZero(List<int> A)
        {
            int maxLen = 0;
            List<int> pSum = new List<int>(A);
            Dictionary<int, int> pSumDic = new Dictionary<int, int>();
            List<int> result = new List<int>();
            int lIndex = 0, rIndex = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (i == 0)
                {
                    pSumDic.Add(A[0], 0);
                    if (pSum[i] == 0)
                    {
                        rIndex = i;
                        maxLen = i + 1;
                    }
                    continue;
                }
                pSum[i] = pSum[i - 1] + A[i];

                if (pSum[i] == 0)
                {
                    lIndex = 0;
                    rIndex = i;
                    maxLen = i + 1;
                }

                if (pSumDic.ContainsKey(pSum[i]))
                {
                    if (maxLen < i - pSumDic[pSum[i]])
                    {
                        maxLen = i - pSumDic[pSum[i]];
                        lIndex = pSumDic[pSum[i]] + 1;
                        rIndex = i;
                    }
                }
                else
                {
                    pSumDic.Add(pSum[i], i);
                }
            }

            if (maxLen > 0)
                for (int i = lIndex; i <= rIndex; i++)
                    result.Add(A[i]);

            return result;
        }

        static int LargestSubarrySumZeroLength(List<int> A)
        {
            int maxLen = 0;
            List<int> pSum = new List<int>(A);
            Dictionary<int, int> pSumDic = new Dictionary<int, int>();
            int lIndex = 0, rIndex = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (i == 0)
                {
                    pSumDic.Add(A[0], 0);
                    continue;
                }
                pSum[i] = pSum[i - 1] + A[i];
                if (pSum[i] == 0)
                {
                    rIndex = i;
                    maxLen = i + 1;
                }

                if (pSumDic.ContainsKey(pSum[i]))
                {
                    if (maxLen < i - pSumDic[pSum[i]])
                    {
                        maxLen = i - pSumDic[pSum[i]];
                        lIndex = pSumDic[pSum[i]];
                        rIndex = i;
                    }
                }
                else
                {
                    pSumDic.Add(pSum[i], i);
                }
            }

            return maxLen;
        }
    }
}
