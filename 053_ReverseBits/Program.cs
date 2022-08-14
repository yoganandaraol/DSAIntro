using System;

namespace _053_ReverseBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseBitsV3(0) == 0 ? "Passed" : "Failed");    //0
            Console.WriteLine(ReverseBitsV3(1) == 2147483648 ? "Passed" : "Failed");   //2147483648 -- 32 - count 
            Console.WriteLine(ReverseBitsV3(2) == 1073741824 ? "Passed" : "Failed");   //1073741824 -- 32 - count - 1
            Console.WriteLine(ReverseBitsV3(3) == 3221225472 ? "Passed" : "Failed");   //3221225472 // 32 - count
            Console.WriteLine(ReverseBitsV3(4) == 536870912 ? "Passed" : "Failed");   //536870912 -- 32 - count - 2
            Console.WriteLine(ReverseBitsV3(6) == 1610612736 ? "Passed" : "Failed");   //1610612736 -- 32 - count - 1     110
            Console.WriteLine(ReverseBitsV3(8) == 268435456 ? "Passed" : "Failed");   //268435456 -- 32 - count - 3
            Console.WriteLine(ReverseBitsV3(9) == 2415919104 ? "Passed" : "Failed");   //2415919104 -- 32 - count
            Console.WriteLine(ReverseBitsV3(10) == 1342177280 ? "Passed" : "Failed");     //1342177280 -- 32 - count - 1
            Console.WriteLine(ReverseBitsV3(4294967294) == 2147483647 ? "Passed" : "Failed");     //1342177280 -- 32 - count - 1 
            Console.WriteLine(ReverseBitsV3(4294967293) == 3221225471 ? "Passed" : "Failed");     
        }

        static long ReverseBits(long A)
        {
            int count = 0;
            int zerosCount = 0;
            var temp = A;
            bool isTrailingZero = true;
            while (temp>0)
            {
                if (isTrailingZero && (temp & 1L) == 0)
                    zerosCount++;
                else
                {
                    isTrailingZero = false;
                }
                count++;
                temp >>= 1;
            }
            var shiftCount = A % 2 == 0 ? 32 - count - zerosCount : 32 - count;
            for (int i = 0; i < shiftCount; i++)
            {
                A <<= 1;
            }

            return A;
        }

        static long ReverseBitsV1(long A)
        {
            long result = 0;

            for (int i = 0; i < 32; i++)
            {
                // 1. get ith bit is 0 or 1 and ith bit will be at last // final result will be like 00001 or 00000
                // 2. will shift last bit to correct position
                // 3. will add bit in result with OR
                result = result | (((A >> i) & 1) << (31 - i));
            }

            return result;
        }

        static long ReverseBitsV2(long A)
        {
            long result = 0;

            for (int i = 0; i < 32; i++)
            {
                result <<= 1;
                if ((A & (1 << i)) != 0)
                    result |= 1;
            }

            return result;
        }

        static long ReverseBitsV3(long A)
        {
            int i = 0;
            long sum = 0;
            while (i < 32)
            {
                long rem = A % 2;
                sum += rem * (long)Math.Pow(2, 31 - i);
                A /= 2;
                i++;
            }

            return sum;
        }
    }
}
