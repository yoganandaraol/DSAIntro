using System;
using System.Collections.Generic;

namespace _016_SeparateOddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int nTestCases = int.Parse(Console.ReadLine().Trim());
            int testIterations = 1;
            List<List<int>> arrsColl = new List<List<int>>();
            while (testIterations <= nTestCases)
            {
                int nTestCaseElements = int.Parse(Console.ReadLine().Trim());
                int[] arrTestCaseElements = new int[nTestCaseElements];
                arrTestCaseElements = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

                List<int> lstTestCaseElements = new List<int>();
                lstTestCaseElements.AddRange(arrTestCaseElements);
                arrsColl.Add(lstTestCaseElements);
                
                testIterations++;
            }

            foreach (var item in arrsColl)
            {
                List<int> evenItems = new List<int>();
                List<int> oddItems = new List<int>();

                for (int i = 0; i < item.Count; i++)
                {
                    if (item[i] % 2 == 0)
                        evenItems.Add(item[i]);
                    else
                        oddItems.Add(item[i]);
                }

                for (int i = 0; i < oddItems.Count; i++)
                {
                    Console.WriteLine(string.Format("{0} ", oddItems[i]));
                }

                for (int i = 0; i < oddItems.Count; i++)
                {
                    Console.WriteLine(string.Format("{0} ", oddItems[i]));
                }

            }
        }
    }
}
