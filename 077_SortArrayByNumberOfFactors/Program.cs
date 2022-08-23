using System;
using System.Collections.Generic;

namespace _077_SortArrayByNumberOfFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static List<int> Solve(List<int> A)
        {
            var result = new List<int>(A);

            for (int i = 0; i < A.Count; i++)
            {
                result.Add(FactorsOfN(A[i]));
            }

            for (int i = 1; i < A.Count; i++)
            {
                if (result[i] < result[i-1])
                {

                }
            }

            return result;
        }

        static int FactorsOfN(int N)
        {
            int count = 0;
            for (int i = 1; i*i <= N; i++)
            {
                if (i * i == N) count++;
                else if (N%i == 0) count += 2;
            }
            return count;
        }
    }
}
