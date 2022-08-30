using System;
using System.Collections.Generic;

namespace _091_SubArraySumZero
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputA = new List<int> { 1, 2, 3, 4, 5, -15 };
            Console.WriteLine(ContainsSubarraySumZeroV1(inputA) == 1 ? "Passed" : "Failed");

            inputA = new List<int> { 1, 2, 3, 4, 5, -14 };
            Console.WriteLine(ContainsSubarraySumZeroV1(inputA) == 1 ? "Passed" : "Failed");

            inputA = new List<int> { 1, 2, 3, 4, 5, -13 };
            Console.WriteLine(ContainsSubarraySumZeroV1(inputA) == 0 ? "Passed" : "Failed");

            inputA = new List<int> { 1, -1 };
            Console.WriteLine(ContainsSubarraySumZeroV1(inputA) == 1 ? "Passed" : "Failed");

            inputA = new List<int> { 0, 1 };
            Console.WriteLine(ContainsSubarraySumZeroV1(inputA) == 1 ? "Passed" : "Failed");

            inputA = new List<int> { 0, -1 };
            Console.WriteLine(ContainsSubarraySumZeroV1(inputA) == 1 ? "Passed" : "Failed");

            inputA = new List<int> { 1, 0 };
            Console.WriteLine(ContainsSubarraySumZeroV1(inputA) == 1 ? "Passed" : "Failed");

            inputA = new List<int> { -1, 0 };
            Console.WriteLine(ContainsSubarraySumZeroV1(inputA) == 1 ? "Passed" : "Failed");

            inputA = new List<int> { 1, 2, 3, 4, -7, -14 };
            Console.WriteLine(ContainsSubarraySumZeroV1(inputA) == 1 ? "Passed" : "Failed");
        }

        static int ContainsSubarraySumZero(List<int> A)
        {
            List<int> pSum = new List<int>(A);
            for (int i = 1; i < A.Count; i++)
            {
                pSum[i] += pSum[i - 1];
            }

            for (int i = 0; i < pSum.Count; i++)
            {
                int saSum = i == 0 ? pSum[0] : pSum[i] - pSum[i - 1];
                if (saSum == 0) return 1;
                for (int j = i + 1; j < pSum.Count; j++)
                {
                    if (i == 0)
                        saSum = pSum[j];
                    else
                        saSum = pSum[j] - pSum[i-1];

                    if (saSum == 0) return 1;
                }
            }

            return 0;
        }

        static int ContainsSubarraySumZeroV1(List<int> A)
        {
            List<long> pSum = new List<long>();
            Dictionary<long, int> pSumFreq = new Dictionary<long, int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (i == 0)
                    pSum.Add(A[0]);
                else
                    pSum.Add(A[i] + pSum[i - 1]);

                if (pSum[i] == 0) return 1;
            }

            for (int i = 0; i < pSum.Count; i++)
            {
                if (pSumFreq.ContainsKey(pSum[i]))
                    return 1;
                else pSumFreq.Add(pSum[i], 1);
            }

            return 0;
        }

        /*
         *  Explanation:
         *      Using prefix sum approach we can solve the proble with TC = O(N)
         *      Prefix sum of array elements have same value means, some of subarray elements sum is zero.
         *      Otherwise prefix sum is continuously increasing.
         */
        static int ContainsSubarraySumZeroV2(List<int> A)
        {
            long sum = 0;
            Dictionary<long, int> pSumFreq = new Dictionary<long, int>();
            foreach (var item in A)
            {
                sum += item;

                if (sum == 0) return 1;

                if (pSumFreq.ContainsKey(sum))
                    return 1;
                else 
                    pSumFreq.Add(sum, 1);
            }

            return 0;
        }
    }
}
