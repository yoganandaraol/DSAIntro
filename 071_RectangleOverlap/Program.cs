/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Eight integers A, B, C, D, E, F, G, and H represent two rectangles in a 2D plane.
        For the first rectangle, its bottom left corner is (A, B), and the top right corner is (C, D), and 
        for the second rectangle, its bottom left corner is (E, F), and the top right corner is (G, H).

        Find and return whether the two rectangles overlap or not.

    Problem Constraints
    -------------------
        -10000 <= A < C <= 10000
        -10000 <= B < D <= 10000
        -10000 <= E < G <= 10000
        -10000 <= F < H <= 10000

    Input Format
    ------------
        The eight arguments are integers A, B, C, D, E, F, G, and H.

    Output Format
    -------------
        Return 1 if the two rectangles overlap else, return 0.

    Sample Input:
    ------------                -------------------             -------------------
        A = 0   B = 0           |          (C,D)  |             |           (G,H) |
        C = 4   D = 4           |                 |             |                 |
        E = 2   F = 2           |                 |             |                 |
        G = 6   H = 6           | (A,B)           |             | (E,F)           |
                                -------------------             -------------------
    Sample Output:
    -------------
        1


    Sample Input:
    ------------
        A = 0   B = 0
        C = 4   D = 4
        E = 2   F = 2
        G = 3   H = 3

    Sample Output:
    -------------
        1
        

 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;

namespace _071_RectangleOverlap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckRectanglesOverlap(0, 0, 4, 4, 2, 2, 6, 6) == 1 ? "Passed" : "Failed");
            Console.WriteLine(CheckRectanglesOverlap(2, 2, 6, 6, 0, 0, 4, 4) == 1 ? "Passed" : "Failed");
            Console.WriteLine(CheckRectanglesOverlap(0, 0, 4, 4, 2, 2, 3, 3) == 1 ? "Passed" : "Failed");
            Console.WriteLine(CheckRectanglesOverlap(0, 0, 4, 4, 5, 5, 6, 6) == 0 ? "Passed" : "Failed");
        }

        static int CheckRectanglesOverlap(int A, int B, int C, int D, int E, int F, int G, int H)
        {
            if (C > E && D > F && G > A && H > B) return 1;
            else return 0;
        }
    }
}
