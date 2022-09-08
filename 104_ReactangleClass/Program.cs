using System;
using System.Collections.Generic;
using System.Linq;

namespace _104_ReactangleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputA = new List<int> { 16, 3, 7, 17, 7, 10, 18, 17, 16 };
            List<int> inputB = new List<int> { 16, 6, 7, 13, 7, 9, 18, 6, 16 };
            List<int> output = new List<int> { 0, 1, 1, 1, 1, 1, 0, 2, 1 };
            Console.WriteLine(Enumerable.SequenceEqual(Solve(inputA, inputB), output) ? "Passed" : "Failed");
        }

        static List<int> Solve(List<int> A, List<int> B)
        {
            Rectangle r;
            var ans = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                r = new Rectangle(A[i], B[i]);
                int area = r.Area();
                int count = 0;
                for (int j = 0; j < i; j++)
                {
                    r = new Rectangle(A[j], B[j]);
                    Console.WriteLine($"inner Area - {r.Area():D3}\t Outer Area - {area:D3}\t {r.CheckAreaIsGreater(area)}");
                    if (r.IsRectangleSquare() && r.CheckAreaIsGreater(area))
                        count++;
                }
                Console.WriteLine();
                ans.Add(count);
            }
            return ans;
        }
    }

    public class Rectangle
    {
        int l;
        int b;

        public Rectangle(int l, int b)
        {
            this.l = l;
            this.b = b;
        }

        public bool IsRectangleSquare()
        {
            return this.l == this.b;
        }

        public int Area()
        {
            return this.l * this.b;
        }

        public bool CheckAreaIsGreater(int k)
        {
            return Area() > k;
        }
    }
}
