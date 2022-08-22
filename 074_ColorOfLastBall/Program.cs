using System;
using System.Collections.Generic;

namespace _074_ColorOfLastBall
{
    class Program
    {
        static void Main(string[] args)
        {
            // 14 Red balls & 20 Blue balls
            List<string> ballsInBag = new List<string> {
                "B","R","B","R","B","R","B","R",
                "B","R","B","R","B","R","B","R",
                "B","R","B","R","B","R","B","R",
                "B","R","B","R","B","B","B","B","B","B"
            };

            // 13 Red balls & 20 blue balls
            ballsInBag = new List<string> {
                "B","R","B","R","B","R","B","R",
                "B","R","B","R","B","R","B","R",
                "B","R","B","R","B","R","B","R",
                "B","R","B","B","B","B","B","B","B"
            };

            int iterations = 0;
            while (ballsInBag.Count > 1)
            {
                iterations++;

                int randIndex = SelectRandomIndex(ballsInBag);
                var ball1 = ballsInBag[randIndex];
                ballsInBag.RemoveAt(randIndex);
                randIndex = SelectRandomIndex(ballsInBag);
                var ball2 = ballsInBag[randIndex];
                ballsInBag.RemoveAt(randIndex);

                if (ball1 == ball2)
                {
                    ballsInBag.Add("B");
                }
                else
                {
                    ballsInBag.Add("R");
                }

                Console.WriteLine(string.Format("{0}\t{1}\t{2}\t{3}", iterations, ball1, ball2,ballsInBag.Count));
            }

            Console.WriteLine();
            Console.WriteLine(iterations);
            Console.WriteLine(ballsInBag[0]);


        }

        private static int SelectRandomIndex(List<string> ballsInBag)
        {
            Random r = new Random();
            return r.Next(0, ballsInBag.Count-1);
        }
    }
}
