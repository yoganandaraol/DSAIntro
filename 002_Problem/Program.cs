using System;

namespace _002_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int iteration = 10;
            //SomeFunction8(iteration);
            //do
            //{
            //    SomeFunction7(iteration);
            //    iteration *= 100;

            //} while (iteration <= 1000000);

            //iteration = 1;
            //do
            //{
            //    SomeFunction7(iteration);
            //    iteration++;

            //} while (iteration <= 20);

            int i = 0;
            while (i < 1000)
            {
                Random r = new Random();
                Console.Write(string.Format("{0} ",r.Next(1, 1000)));
                i++;
            }


        }

        private static void SomeFunction(int n)
        {
            //string nString = Console.ReadLine();
            //int n = int.Parse(nString);

            int count = 0;

            // What is the time complexity of below code

            for (int i = n; i > 0; i /= 2)
            {
                for (int j = 0; j < i; j++)
                {
                    count += 1;
                    //Console.WriteLine(string.Format("{0}\t{1}\t{2}", i, j, count));
                }
                //count += 1;
            }
            Console.WriteLine(string.Format("--\t{0}\t{1}\t--", n, count));
        }

        private static void SomeFunction2(int n)
        {
            //string nString = Console.ReadLine();
            //int n = int.Parse(nString);

            int count = 0;

            // What is the time complexity of below code

            for (int i = 3; i < n/3; i += 3)
            {
                for (int j = 2; j < n/2; j += 2)
                {
                    count += 1;
                    //Console.WriteLine(string.Format("{0}\t{1}\t{2}", i, j, count));
                }
                //count += 1;
            }
            Console.WriteLine(string.Format("--\t{0}\t{1}\t--", n, count));
        }

        private static void SomeFunction3(int n)
        {
            //string nString = Console.ReadLine();
            //int n = int.Parse(nString);

            int count = 0;
            int i = 1;
            // What is the time complexity of below code

            while (i < n)
            {
                int x = i;
                while (x-- > 0)
                {
                    count++;
                }
                i++;
            }
            Console.WriteLine(string.Format("--\t{0}\t{1}\t{2}--", n, count, n * (n - 1) / 2));

        }

        private static void SomeFunction4(int n)
        {
            //string nString = Console.ReadLine();
            //int n = int.Parse(nString);

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j >= 0; j++)
                {
                    count++;
                    Console.WriteLine(string.Format("{0} - {1} - {2}",i, j, count));
                }
            }
            Console.WriteLine(string.Format("--\t{0}\t{1}\t{2}--", n, count, n * (n - 1) / 2));

        }

        private static void SomeFunction5(int n)
        {
            //string nString = Console.ReadLine();
            //int n = int.Parse(nString);

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    count++;
                    //Console.WriteLine(string.Format("{0} - {1} - {2}", i, j, count));
                    break;
                }
            }
            Console.WriteLine(string.Format("--\t{0}\t{1}\t--", n, count));

        }

        private static void SomeFunction6(int n)
        {
            //string nString = Console.ReadLine();
            //int n = int.Parse(nString);

            int count = 0;
            while (n > 0)
            {
                n = n / 3;
            }
            Console.WriteLine(string.Format("--\t{0}\t{1}\t--", n, count));

        }

        private static void SomeFunction7(int n)
        {
            //string nString = Console.ReadLine();
            //int n = int.Parse(nString);

            int count = 0;
            for (int i = 0; i < (1 << n); i++)
            {
                int j = i;
                while (j > 0)
                {
                    j--;
                    count++;
                }
                Console.WriteLine(string.Format("{0}\t{1}", i, count));
            }
            //Console.WriteLine(string.Format("--\t{0}\t{1}\t--", n, count));

        }

        private static void SomeFunction8(int n)
        {
            //string nString = Console.ReadLine();
            //int n = int.Parse(nString);

            int count = 0;
            for (int i = 1; i * i <= n; i++)
            {
                for (int j = 0; j*j < i; j+= i)
                {
                    count++;
                    //Console.WriteLine(string.Format("{0} - {1} - {2}", i, j, count));
                }
                //Console.WriteLine(string.Format("{0} - {1} - {2}", i, j, count));

            }
            Console.WriteLine(string.Format("--\t{0}\t{1}\t--", n, count));

        }
    }
}
