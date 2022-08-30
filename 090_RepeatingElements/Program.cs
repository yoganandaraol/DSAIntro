using System;
using System.Collections.Generic;

namespace _090_RepeatingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputA = new List<int> { 10, 5, 3, 4, 3, 5, 6 };
            Console.WriteLine(FindRepeatedElement(inputA) == 5 ? "Passed" : "Failed");

            inputA = new List<int> { 6, 10, 5, 4, 9, 120 };
            Console.WriteLine(FindRepeatedElement(inputA) == -1 ? "Passed" : "Failed");
        }

        static int FindRepeatedElement(List<int> A)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (var item in A)
            {
                if (dic.ContainsKey(item))
                    dic[item] += 1;
                else
                    dic[item] = 1;
            }

            foreach (var item in A)
            {
                if (dic[item] > 1) return item;
            }

            return -1;
        }
    }
}
