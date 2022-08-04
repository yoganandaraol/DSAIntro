using System;

namespace _007_ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] arr2 = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ReverseArray(arr1);

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
        }

        public static void ReverseArray(int[] a) 
        {
            int lIndex, rIndex;
            for (int i = 0; i <= a.Length / 2; i++)
            {
                lIndex = i;
                rIndex = a.Length - 1 - i;
                Swap(a, lIndex, rIndex);
            }
        }
        static void Swap(int[] a, int lIndex, int rIndex)
        {
            int temp = a[lIndex];
            a[lIndex] = a[rIndex];
            a[rIndex] = temp;
        }
    }
}
