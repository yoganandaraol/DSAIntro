using System;
using System.Collections.Generic;

namespace _029_SmartBulbs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<int>() { 0, 1, 0, 1 }; // Ans = 4
            //var input = new List<int>() { 1,1,1,1}; // Ans = 0
            //var input = new List<int>() { 1,1,0,0}; // Ans = 1
            Console.WriteLine(bulbs(input));
        }

        static int bulbs(List<int> A)
        {
            int count = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] == 1)
                {
                    continue;
                }
                else
                {
                    for (int j = i+1; j < A.Count; j++)
                    {
                        A[j] = A[j] == 0 ? 1 : 0;
                    }
                    count++;
                }

            }
            return count;
        }
        static int bulbsV1(List<int> A)
        {
            int count = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] == 1)
                {
                    continue;
                }
                else
                {
                    for (int j = i + 1; j < A.Count; j++)
                    {
                        A[j] = A[j] == 0 ? 1 : 0;
                    }
                    count++;
                }

            }
            return count;
        }
    }
}
