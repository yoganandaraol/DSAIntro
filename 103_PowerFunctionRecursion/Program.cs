using System;

namespace _103_PowerFunctionRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solve(2, 3, 10000) == 8 ? "Passed" : "Failed");
            Console.WriteLine(Solve(1, 3000, 10000) == 1 ? "Passed" : "Failed");
            Console.WriteLine(Solve(11234, 0, 10000) == 1 ? "Passed" : "Failed");
            Console.WriteLine(Solve(-212341234, 323452345, 1000023) == 772601 ? "Passed" : "Failed");
            Console.WriteLine(Solve(212341234, 323452345, 1000023) == 227422 ? "Passed" : "Failed");
            Console.WriteLine(Solve(71045970, 41535484, 64735492) == 20805472 ? "Passed" : "Failed");
        }

        static int Solve(int A, int B, int C)
        {
            var result = FastPower(A, B, C);
            if (result < 0)
            {
                return (int)(C + result)%C;
            }
            return (int)result;
        }

        static long FastPower(int A, int B, int C)
        {
            if (A == 0) return 0;
            if (B == 0) return 1;

            long val = FastPower(A, B / 2, C);

            if (B % 2 == 1)
            {
                return (((val * val) % C) * A) % C;
            }
            else
                return (val * val) % C;

        }
    }
}
