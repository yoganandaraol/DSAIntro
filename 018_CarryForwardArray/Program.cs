using System;

namespace _018_CarryForwardArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = Solve(new char[] { 'g', 'c', 'a', 'g', 'g', 'a', 'a', 'g' }, 'a', 'g');
            Console.WriteLine(res);
        }

        static int Solve(char[] a, char c1, char c2)
        {
            int ans = 0;
            int cnt = 0;

            for (int i = a.Length-1; i >= 0; i--)
            {
                if (a[i] == c2) cnt += 1;
                if (a[i] == c1) ans += cnt;
            }
            return ans;
        }

    }
}
