using System;
using System.Collections.Generic;
using System.Linq;

namespace _111_Misc
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputA = 5;
            List<List<int>> inputB = new List<List<int>>{
                new List<int> {1, 2, 10 },
                new List<int> {2, 3, 20 },
                new List<int> { 2, 5, 25 }
            };
            List<int> output = new List<int> { 10, 55, 45, 25, 25 };

            Console.WriteLine(Enumerable.SequenceEqual(solve(inputA, inputB), output) ? "Passed" : "Failed");

        }

        public static List<int> solve(int A, List<List<int>> B)
        {
            var result = new List<int>();
            for (int i = 0; i < A; i++)
            {
                result.Add(0);
            }
            foreach (var bItems in B)
            {
                int start = bItems[0] - 1;
                int end = bItems[1] -1;
                int val = bItems[2];

                result[start] += val;
                if (end < A - 1)
                {
                    result[end + 1] -= val;
                }
            }

            for (int i = 1; i < result.Count; i++)
            {
                result[i] += result[i-1];
            }

            return result;
        }

    }
}
