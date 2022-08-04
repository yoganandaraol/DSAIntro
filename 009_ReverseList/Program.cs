using System;
using System.Collections.Generic;

namespace _009_ReverseList
{
    class Program
    {
        static void Main(string[] args)
        {
            var strArr = Console.ReadLine().Replace(" ", String.Empty).Replace("[", "").Replace("]", "").Split(','); //[                              1, 2, 3,4, 5               , 6, 7]
            var A = Array.ConvertAll(strArr, Convert.ToInt32);
            Solve(A);
            foreach (var item in A)
            {
                Console.WriteLine(item);
            }

        }

        public static List<int> Solve(int[] A)
        {
            for (int i = 0; i < A.Length/2; i++)
            {
                Swap(A, i, A.Length - 1 - i);
            }
            var list = new List<int>();
            list.AddRange(A);
            return list;
        }
        static void Swap(int[] a, int lIndex, int rIndex)
        {
            int temp = a[lIndex];
            a[lIndex] = a[rIndex];
            a[rIndex] = temp;
        }
    }
}
