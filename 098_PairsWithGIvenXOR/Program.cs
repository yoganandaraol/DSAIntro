using System;
using System.Collections.Generic;

namespace _098_PairsWithGIvenXOR
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputA = new List<int> { 5, 4, 10, 15, 7, 6 };
            Console.WriteLine(XORPairsInListV1(inputA, 5) == 1 ? "Passed" : "Failed");

            inputA = new List<int> { 3, 6, 8, 10, 15, 50 };
            Console.WriteLine(XORPairsInListV1(inputA, 5) == 2 ? "Passed" : "Failed");

        }

        // Using this approach results TLE for larger inputs
        static int XORPairsInList(List<int> A, int B)
        {
            int ans = 0;
            for (int i = 0; i < A.Count-1; i++)
            {
                for (int j = i+1; j < A.Count; j++)
                {
                    if ((A[i] ^ A[j]) == B)
                    {
                        ans++;
                    }
                }
            }
            return ans;
        }

        // Considering A^B = C then A^C = B
        static int XORPairsInListV1(List<int> A, int B)
        {
            Dictionary<int, int> xorDic = new Dictionary<int, int>();
            int ans = 0;

            for (int i = 0; i < A.Count; i++)
            {
                if (xorDic.ContainsKey(A[i]))
                    ans++;

                xorDic.Add(B ^ A[i], i);
            }
            return ans;
        }

    }
}
