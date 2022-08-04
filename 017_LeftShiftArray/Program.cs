using System;
using System.Collections.Generic;

namespace _017_LeftShiftArray
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().solve(new List<int> { 1, 2, 3, 4, 5 }, new List<int> { 2, 3});
        }

        public List<List<int>> solve(List<int> A, List<int> B)
        {
            var result = new List<List<int>>();
            foreach (var item in B)
            {
                var arr = new List<int>(A);
                 
                int shiftLen = arr.Count - (item % arr.Count);
                Reverse(arr, 0, arr.Count - 1);
                Reverse(arr, 0, shiftLen - 1);
                Reverse(arr, shiftLen, arr.Count - 1);

                result.Add(arr);
            }
            return result;
        }

        static void Reverse(List<int> lst, int lIndex, int rIndex)
        {
            while (lIndex < rIndex)
            {
                Swap(lst, lIndex, rIndex);
                lIndex++;
                rIndex--;
            }
        }

        static void Swap(List<int> lst, int lIndex, int rIndex)
        {
            int temp = lst[lIndex];
            lst[lIndex] = lst[rIndex];
            lst[rIndex] = temp;
        }
    }
}
