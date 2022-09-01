using System;
using System.Collections.Generic;

namespace _091_SumOfRepeatedDistinctElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputC = new List<int> { 1, 2, 2, 3, 3 };
            Console.WriteLine(SumOfRepeatedDistinctElements(5, 2, inputC) == 5 ? "Passed" : "Failed");

            inputC = new List<int> { 0, 0, 1 };
            Console.WriteLine(SumOfRepeatedDistinctElements(3, 2, inputC) == 0 ? "Passed" : "Failed");

            inputC = new List<int> { 3, 0, 2 };
            Console.WriteLine(SumOfRepeatedDistinctElements(3, 1, inputC) == 5 ? "Passed" : "Failed");

            inputC = new List<int> { 0, 0, 0, 0 };
            Console.WriteLine(SumOfRepeatedDistinctElements(4, 1, inputC) == -1 ? "Passed" : "Failed");

            inputC = new List<int> { 1000000000, 1000000000, 999999999, 999999999, 999999998, 1 }; 
            Console.WriteLine(SumOfRepeatedDistinctElements(6, 2, inputC) == 999999992 ? "Passed" : "Failed");
        }

        static int SumOfRepeatedDistinctElements(int A, int B, List<int> C)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int ans = -1;
            foreach (var item in C)
            {
                if (dic.ContainsKey(item))
                    dic[item] += 1;
                else
                    dic.Add(item, 1);

                if (dic[item] == B)
                {
                    if (ans == -1)
                        ans = 0;
                    ans = (ans + item) % 1000000007;
                }

                if (dic[item] == C.Count) return -1;

            }

            return ans;
        }
    }
}


