using System;
using System.Collections.Generic;

namespace _045_LowestPriceCristmasTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            //var inputA = new List<int> { 1, 3, 5 };
            //var inputB = new List<int> { 1, 2, 3 };
            //Ans - 6

            //var inputA = new List<int> { 1, 6, 4, 2, 6, 9 };
            //var inputB = new List<int> { 2, 5, 7, 3, 2, 7 };
            // Ans - 7

            var inputA = new List<int> { 5, 9, 10, 4, 7, 8 };
            var inputB = new List<int> { 5, 6, 4, 7, 2, 5 };
            //// Ans - 12

            //var inputA = new List<int> { 2, 4, 5, 4, 10 };
            //var inputB = new List<int> { 40, 30, 20, 10, 10 };
            // Ans - 90
            var result = solve(inputA, inputB);

            Console.WriteLine(result);
        }

        static int solve(List<int> A, List<int> B)
        {
            if (A.Count >= 3)
            {
                int min1 = int.MaxValue - 3;
                int min2 = int.MaxValue - 2;
                int min3 = int.MaxValue - 1;
                int minIndex1 = A.Count-2;
                int minIndex2 = A.Count-1;
                int minIndex3 = A.Count;

                for (int i = 0; i < A.Count; i++)
                {
                    if (A[i] <= min1)
                    {
                        if (minIndex1 < A.Count && minIndex2 < A.Count && minIndex3 < A.Count)
                        {
                            if (B[i] < B[minIndex1])
                            {
                                min3 = int.MaxValue - 1;
                                minIndex3 = A.Count - 2;
                                min2 = int.MaxValue - 2;
                                minIndex2 = A.Count - 1;
                                min1 = A[i];
                                minIndex1 = i;
                            }
                        }
                        else
                        {
                            min1 = A[i];
                            minIndex1 = i;
                        }

                    }
                    else if (A[i] <= min2)
                    {
                        if (minIndex1 < A.Count && minIndex2 < A.Count && minIndex3 < A.Count)
                        {
                            if (B[i] < B[minIndex2])
                            {
                                min3 = int.MaxValue - 1;
                                minIndex3 = A.Count - 2;
                                min2 = A[i];
                                minIndex2 = i;
                            }
                        }
                        else
                        {
                            min2 = A[i];
                            minIndex2 = i;
                        }

                    }
                    else if (A[i] <= min3)
                    {
                        if (minIndex1 < A.Count && minIndex2 < A.Count && minIndex3 < A.Count)
                        {
                            if (B[i] < B[minIndex3])
                            {
                                min3 = A[i];
                                minIndex3 = i;
                            }
                        }
                        else
                        {
                            min3 = A[i];
                            minIndex3 = i;
                        }
                    }

                }

                if (minIndex1 == A.Count || minIndex2 == A.Count || minIndex3 == A.Count) return -1;

                return B[minIndex1] + B[minIndex2] + B[minIndex3];
            }
            else return -1;
        }
    }
}
