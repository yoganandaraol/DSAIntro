using System;

namespace _102_IsMagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckMagicNumberV1(83557) == 1 ? "Passed" : "Failed");
            Console.WriteLine(CheckMagicNumberV1(1291) == 0 ? "Passed" : "Failed");
        }

        static int CheckMagicNumber(int A)
        {
            return SumOfDigits(A) == 1 ? 1 : 0;
        }

        /*
         * 
         *      One approach is to recursively check the sum of digits until a single digit is left.
         *      Now, check if the number is 1, then it is a magic number. Else NOT.
         *
         *      Efficient Approach:
         *      -------------------
         *      
         *      There is also a shortcut method to verify Magic Number.
         *      The function will determine if the remainder of dividing the input by 9 is 1 or not.
         *      If it is 1, then the number is a magic number.
         *      The divisibility rule of 9 says that a number is divisible by 9 if the sum of its digits is also divisible by 9.
         *      Therefore, if a number is divisible by 9, then, recursively, all the digit sums are also divisible by 9.
         *      The final digit sum is always 9. 
         *      An increase of 1 in the original number will increase the ultimate value by 1, making it 10, and the ultimate sum will be 1, thus verifying that it is a magic number.
         * 
         */
        static int CheckMagicNumberV1(int A)
        {
            if (A % 9 == 1)
            {
                return 1;
            }
            return 0;
        }

        static int SumOfDigits(int A)
        {
            if (A <= 9)
            {
                return A;
            }
            return SumOfDigits(SumOfDigits(A / 10) + (A % 10));
        }
    }
}
