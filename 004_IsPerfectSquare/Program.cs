using System;

namespace _004_IsPerfectSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            string nString = Console.ReadLine();
            int n = int.Parse(nString);

            Console.WriteLine(FindPerfectSquare(n));
        }

        public static int FindPerfectSquare(int n)
        {
            int result = 0;
            for (int i = 1; i * i <= n; i++)
            {
                result = i * i == n ? i : -1;
            }
            return result;
        }
    }
}
