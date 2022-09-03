using System;

namespace _101_RecursionPractice
{
    class Program
    {
        /*
         * 
         * Q1. What is output of foo(3,5)?
         * Q2. What is output of fun(2,10)
         * Q3. Reverse a string using recursion.
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine(foo(3, 5));
            Console.WriteLine(fun(2, 10));
            StringReverseRecursive("scaleracademy", 12);
        }

        static int bar(int x, int y)
        {
            if (y == 0) return 0;
            return (x + bar(x, y - 1));
        }

        static int foo(int x, int y)
        {
            if (y == 0) return 1;
            return bar(x, foo(x, y - 1));
        }

        static int fun(int x, int n)
        {
            if (n == 0)
                return 1;
            else if (n % 2 == 0)
                return fun(x * x, n / 2);
            else
                return x * fun(x * x, (n - 1) / 2);
        }

        static void StringReverseRecursive(string s, int index)
        {
            if (index == 0)
            {
                Console.WriteLine(s[0]);
                return;
            }
            Console.WriteLine(s[index]);
            StringReverseRecursive(s, index - 1);
        }
    }
}
