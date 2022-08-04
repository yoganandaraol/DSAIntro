using System;

namespace _003_SumOf_N_NaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string nString = Console.ReadLine();
            int n = int.Parse(nString);

            //Console.WriteLine(SumOfNaturalNumbers(n));
            Console.WriteLine(SumOfNaturalNumbersUsingLoops(n));
        }

        public static int SumOfNaturalNumbers(int n)
        {
            return n * (n + 1) / 2;
        }

        public static int SumOfNaturalNumbersUsingLoops(int n)
        {
            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += i;
            }
            return result;
        }
    }
}
