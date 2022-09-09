using System;
using System.Collections.Generic;

namespace _106_GreyCode
{
    class Program
    {
        static void Main(string[] args)
        {
            generateGrayarr(5);

            var ans = new List<int>();
            var output = GrayCode(5, ans);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }

        // This function generates all n
        // bit Gray codes and prints the
        // generated codes
        static List<String> generateGray(int n)
        {

            // Base case
            if (n <= 0)
            {
                return new List<String>() { "0" };
            }
            if (n == 1)
            {
                return new List<String>() { "0", "1" };
            }

            // Recursive case
            List<String> recAns = generateGray(n - 1);
            List<String> mainAns = new List<String>();

            // Append 0 to the first half
            for (int i = 0; i < recAns.Count; i++)
            {
                String s = recAns[i];
                mainAns.Add("0" + s);
            }

            // Append 1 to the second half
            for (int i = recAns.Count - 1; i >= 0; i--)
            {
                String s = recAns[i];
                mainAns.Add("1" + s);
            }
            return mainAns;
        }

        // Function to generate the
        // Gray code of N bits
        static void generateGrayarr(int n)
        {
            List<String> arr = new List<String>();
            arr = generateGray(n);

            // print contents of arr
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static List<int> GrayCode(int a, List<int> codes)
        {
            if (a == 1)
            {
                codes.Add(0);
                codes.Add(1);
                return codes;
            }
            GrayCode(a - 1, codes);
            for (int i = codes.Count - 1; i >= 0; i--)
            {
                codes.Add(codes[i] | (1 << (a - 1)));
            }
            return codes;
        }
    }
}
