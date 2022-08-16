using System;
using System.Text;

namespace _064_StarPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = DateTime.Now;
            var steps = int.Parse(Console.ReadLine());
            PrintDiamond(steps);
            Console.WriteLine(DateTime.Now - t1);
        }

        static void PrintDiamond(int steps)
        {
            var sb = new StringBuilder();
            for (int j = 0; j < 2 * steps; j++)
            {
                for (int k = 0; k < 2 * steps; k++)
                {
                    if (j < steps)
                    {
                        if (k < steps - j || k >= steps + j)
                        {
                            sb.Append("*");
                        }
                        else sb.Append(" ");
                    }
                    else
                    {
                        if (k < j - (steps - 1) || k >= 2 * steps - 1 - j % steps)
                        {
                            sb.Append("*");
                        }
                        else sb.Append(" ");

                    }

                    if (k == 2 * steps - 1)
                    {
                        sb.Append(Environment.NewLine);
                    }
                }

            }
            Console.WriteLine(sb.ToString());
        }

        static void PrintDiamondV1(int steps)
        {
            var sb = new StringBuilder();
            for (int j = 0; j < steps; j++)
            {
                for (int k = 0; k < steps; k++)
                {
                    if (j < steps)
                    {
                        if (k < steps - j)
                        {
                            sb.Append("*");
                        }
                        else sb.Append(" ");
                    }
                    else
                    {
                        if (k < j - (steps - 1) || k >= 2 * steps - 1 - j % steps)
                        {
                            sb.Append("*");
                        }
                        else sb.Append(" ");

                    }

                    if (k == 2 * steps - 1)
                    {
                        sb.Append(Environment.NewLine);
                    }
                }

            }
            Console.WriteLine(sb.ToString());
        }
    }
}
