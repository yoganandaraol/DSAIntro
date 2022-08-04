using System;

namespace _005_ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string nString = Console.ReadLine();
            int n = int.Parse(nString);
            //IsArmstrongNumber(n);
            IsArmstrongNumberWhile(n);
        }

        public static void IsArmstrongNumber(int n)
        {
            /*
             * Example for armstrong number 
             * 
             * 1^3 + 5^3 + 3^3 = 153
             * 
             */
            var t1 = DateTime.Now;
            for (int i = 1; i <= n; i++)
            {
                string strDigit = i.ToString();
                int maxDigits = strDigit.Length;
                int sum = 0;

                for (int j = 1; j <= maxDigits; j++)
                {
                    int currentDigit = int.Parse(strDigit[j - 1].ToString());
                    sum += currentDigit * currentDigit * currentDigit;
                    //sum += PowerOf(currentDigit, maxDigits);
                }

                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
            var t2 = DateTime.Now;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(t2-t1);
            Console.ResetColor();
        }

        public static void IsArmstrongNumberWhile(int n)
        {
            /*
             * Example for armstrong number 
             * 
             * 1^3 + 5^3 + 3^3 = 153
             * 
             */

            var t1 = DateTime.Now;
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int currentNumber = i;
                int quotient;

                string strDigit = currentNumber.ToString();
                int maxDigits = strDigit.Length;

                do
                {
                    int reminder = Convert.ToInt32(currentNumber % 10);
                    quotient = Convert.ToInt32(currentNumber / 10);
                    sum += PowerOf(reminder, maxDigits);
                    currentNumber = quotient;
                } while (quotient > 0);

                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
            var t2 = DateTime.Now;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(t2 - t1);
            Console.ResetColor();
        }

        public static int PowerOf(int x, int y) 
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }
    }
}
