using System;
using System.Collections.Generic;

namespace _014_SecondLargest
{
    class Program
    {
        static void Main(string[] args)
        {
            //var lst = new List<int> { 2, 1, 2 };
            var lst = new List<int> { 2 };
            Console.WriteLine(SecondLargest(lst));
        }

        public static int SecondLargest(List<int> A)
        {
            bool flag = A.Count > 1;

            for (int i = 0; i < A.Count; i++)
            {
                for (int j = i + 1; flag && j < A.Count; j++)
                {
                    if (A[i] < A[j])
                    {
                        Swap(A, i, j);
                    }

                }
            }
            return flag ? A[1] : -1;
        }
        static void Swap(List<int> A, int lIndex, int rIndex)
        {
            int temp = A[lIndex];
            A[lIndex] = A[rIndex];
            A[rIndex] = temp;
        }
    }
}
