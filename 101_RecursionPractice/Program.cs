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
         * Callstack for foo(3,5)
         *  foo(3,5)
            foo(3,4)
            foo(3,3)
            foo(3,2)
            foo(3,1)
            bar(3,1)
            bar(3,3)
            bar(3,2)
            bar(3,1)
            bar(3,9)
            bar(3,8)
            bar(3,7)
            bar(3,6)
            bar(3,5)
            bar(3,4)
            bar(3,3)
            bar(3,2)
            bar(3,1)
            bar(3,27)
            bar(3,26)
            bar(3,25)
            bar(3,24)
            bar(3,23)
            bar(3,22)
            bar(3,21)
            bar(3,20)
            bar(3,19)
            bar(3,18)
            bar(3,17)
            bar(3,16)
            bar(3,15)
            bar(3,14)
            bar(3,13)
            bar(3,12)
            bar(3,11)
            bar(3,10)
            bar(3,9)
            bar(3,8)
            bar(3,7)
            bar(3,6)
            bar(3,5)
            bar(3,4)
            bar(3,3)
            bar(3,2)
            bar(3,1)
            bar(3,81)
            bar(3,80)
            bar(3,79)
            bar(3,78)
            bar(3,77)
            bar(3,76)
            bar(3,75)
            bar(3,74)
            bar(3,73)
            bar(3,72)
            bar(3,71)
            bar(3,70)
            bar(3,69)
            bar(3,68)
            bar(3,67)
            bar(3,66)
            bar(3,65)
            bar(3,64)
            bar(3,63)
            bar(3,62)
            bar(3,61)
            bar(3,60)
            bar(3,59)
            bar(3,58)
            bar(3,57)
            bar(3,56)
            bar(3,55)
            bar(3,54)
            bar(3,53)
            bar(3,52)
            bar(3,51)
            bar(3,50)
            bar(3,49)
            bar(3,48)
            bar(3,47)
            bar(3,46)
            bar(3,45)
            bar(3,44)
            bar(3,43)
            bar(3,42)
            bar(3,41)
            bar(3,40)
            bar(3,39)
            bar(3,38)
            bar(3,37)
            bar(3,36)
            bar(3,35)
            bar(3,34)
            bar(3,33)
            bar(3,32)
            bar(3,31)
            bar(3,30)
            bar(3,29)
            bar(3,28)
            bar(3,27)
            bar(3,26)
            bar(3,25)
            bar(3,24)
            bar(3,23)
            bar(3,22)
            bar(3,21)
            bar(3,20)
            bar(3,19)
            bar(3,18)
            bar(3,17)
            bar(3,16)
            bar(3,15)
            bar(3,14)
            bar(3,13)
            bar(3,12)
            bar(3,11)
            bar(3,10)
            bar(3,9)
            bar(3,8)
            bar(3,7)
            bar(3,6)
            bar(3,5)
            bar(3,4)
            bar(3,3)
            bar(3,2)
            bar(3,1)
         * 
         * 
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
            Console.WriteLine($"bar({x},{y})");
            return (x + bar(x, y - 1));
        }

        static int foo(int x, int y)
        {
            if (y == 0) return 1;
            Console.WriteLine($"foo({x},{y})");
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
                Console.Write(s[0]);
                return;
            }
            Console.Write(s[index]);
            StringReverseRecursive(s, index - 1);
        }
    }
}
