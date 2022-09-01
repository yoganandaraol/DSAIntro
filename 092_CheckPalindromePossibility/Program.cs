using System;
using System.Collections.Generic;

namespace _092_CheckPalindromePossibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckPlindromePossible("vnpbeutxfqxriiajoejjmtjcx") == 0 ? "Passed" : "Failed");
            Console.WriteLine(CheckPlindromePossible("aebbea") == 1 ? "Passed" : "Failed");
            Console.WriteLine(CheckPlindromePossible("abcde") == 0 ? "Passed" : "Failed");
        }

        static int CheckPlindromePossible(string A)
        {
            Dictionary<char, int> freqs = new Dictionary<char, int>();
            foreach (var item in A)
            {
                if (freqs.ContainsKey(item))
                    freqs[item] += 1;
                else
                    freqs.Add(item, 1);
            }

            int oddFreqCount = 0;
            foreach (var item in freqs)
            {
                if (item.Value % 2 == 1)
                {
                    oddFreqCount++;
                    if (oddFreqCount == 2)
                        return 0;
                }
            }

            return 1;
        }
    }
}
