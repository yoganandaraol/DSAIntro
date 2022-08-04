using System;

namespace _012_FindMinMaxInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                        Swap(arr, i, j);
                }
                
                
            }

            Console.Write(string.Format("{0} {1}", arr[0], arr[arr.Length - 2]));

        }
        static void Swap(int[] A, int lIndex, int rIndex)
        {
            int temp = A[lIndex];
            A[lIndex] = A[rIndex];
            A[rIndex] = temp;
        }
    }
}
