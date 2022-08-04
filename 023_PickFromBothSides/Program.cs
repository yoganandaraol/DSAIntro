using System;
using System.Collections.Generic;

namespace _023_PickFromBothSides
{
    class Program
    {
        static void Main(string[] args)
        {

            //var ipList = new List<int> { 1, 2, 3, 7, 1, 2, 3 };
            var ipList = new List<int> { -969, -948, 350, 150, -59, 724, 966, 430, 107, -809, -993, 337, 457, -713, 753, -617, -55, -91, -791, 758, -779, -412, -578, -54, 506, 30, -587, 168, -100, -409, -238, 655, 410, -641, 624, -463, 548, -517, 595, -959, 602, -650, -709, -164, 374, 20, -404, -979, 348, 199, 668, -516, -719, -266, -947, 999, -582, 938, -100, 788, -873, -533, 728, -107, -352, -517, 807, -579, -690, -383, -187, 514, -691, 616, -65, 451, -400, 249, -481, 556, -202, -697, -776, 8, 844, -391, -11, -298, 195, -515, 93, -657, -477, 587 };
            Console.WriteLine(MaxPossibleSumOfFewElementsInArray(ipList, 81));
        }

        static int MaxPossibleSumOfFewElementsInArray(List<int> A, int B)
        {
            var prefixsum = new List<int>(A);
            var suffixsum = new List<int>(A);

            for (int i = 1; i < A.Count; i++)
            {
                prefixsum[i] += prefixsum[i - 1];
                suffixsum[A.Count - 1 - i] += suffixsum[A.Count - i];
            }

            int maxSum = int.MinValue;

            for (int i = 0; i <= B; i++)
            {
                int totalSum = 0;
                if (i == 0)
                {
                    totalSum = prefixsum[B - 1];
                }
                else if (i == B)
                {
                    totalSum = suffixsum[A.Count - B];
                }
                else
                {
                    totalSum = prefixsum[B - (i + 1)] + suffixsum[A.Count - i];
                }

                maxSum = maxSum > totalSum ? maxSum : totalSum;
            }

            return maxSum;
        }
    }
}
