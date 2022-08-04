using System;

namespace _001_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string nString = Console.ReadLine();
            int n = int.Parse(nString);
            SomeWork(n);
        }

        public static void SomeWork(int n)
        {
            int i = 1;
            while (i < n)
            {
                int x = i;
                while (x-- > 0)
                {
                    Console.WriteLine(string.Format("i\t{0}\tx\t{1}", i, x));
                }
                Console.WriteLine("--------");
                i++;
            }
        }
    }
}
