using System;

namespace _002_IsPerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumbers = int.Parse(Console.ReadLine());
            for (int i = 0; i < totalNumbers; i++)
            {
                int givenNumber = int.Parse(Console.ReadLine());
                if (IsPerfectNumber(givenNumber))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
            
        }

        public static bool IsPerfectNumber(int n)
        {
            int sumOfDivisors = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sumOfDivisors += i;
                }
            }

            return sumOfDivisors == n;
        }
    }
}
