using System;

namespace _006_Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            string nString = Console.ReadLine();
            int n = int.Parse(nString);
            PrintTable(n);
        }

        public static void PrintTable(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(string.Format("{0} * {1} = {2}", n, i, n*i));
            }
        }
    }
}
