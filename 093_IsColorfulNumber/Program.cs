using System;
using System.Collections.Generic;

namespace _093_IsColorfulNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsColorfulNumber(1234) == 0 ? "Passed" : "Failed");
            Console.WriteLine(IsColorfulNumber(23) == 1 ? "Passed" : "Failed");
            Console.WriteLine(IsColorfulNumber(236) == 0 ? "Passed" : "Failed");
        }

        static int IsColorfulNumber(int A)
        {
            int reminder = A;
            HashSet<int> hsProduct = new HashSet<int>();
            List<int> digits = new List<int>();
            while (reminder > 0)
            {
                digits.Add(reminder % 10);
                reminder /= 10;
            }

            if (digits.Count == 1) return 1;
            else if (digits.Contains(1)) return 0;

            digits.Reverse();

            for (int i = 0; i < digits.Count; i++)
            {
                int product = 1;
                for (int j = i; j < digits.Count; j++)
                {
                    product *= digits[j];
                    if (hsProduct.Contains(product))
                        return 0;
                    else
                        hsProduct.Add(product);
                }
            }

            return 1;
        }
    }
}
