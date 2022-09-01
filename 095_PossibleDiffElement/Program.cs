using System;
using System.Collections.Generic;

namespace _095_PossibleDiffElement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputA = new List<int> { 1, 5, 3 };
            Console.WriteLine(PossibleDiffElement(inputA, 2) == 1 ? "Passed" : "Failed");

            inputA = new List<int> { 2, 4, 3 };
            Console.WriteLine(PossibleDiffElement(inputA, 3) == 0 ? "Passed" : "Failed");

            inputA = new List<int> { 77, 28, 19, 21, 67, 15, 53, 25, 82, 52, 8, 94, 50, 30, 37, 39, 9, 43, 35, 48, 82, 53, 16, 20, 13, 95, 18, 67, 77, 12, 93, 0 };
            Console.WriteLine(PossibleDiffElement(inputA, 53) == 1 ? "Passed" : "Failed");

            inputA = new List<int> { 1, 3, 2 };
            Console.WriteLine(PossibleDiffElement(inputA, 0) == 0 ? "Passed" : "Failed");

            inputA = new List<int> { 1, 3, 2, 3 };
            Console.WriteLine(PossibleDiffElement(inputA, 0) == 1 ? "Passed" : "Failed");

            inputA = new List<int> { 1, 3, 2, 2 };
            Console.WriteLine(PossibleDiffElement(inputA, 0) == 1 ? "Passed" : "Failed");

            inputA = new List<int> { 95, 97, 52, 51, 98, 41, 88, 12, 61, 32, 78, 9, 51, 39, 28, 28 };
            Console.WriteLine(PossibleDiffElement(inputA, 43) == 1 ? "Passed" : "Failed");
        }

        static int PossibleDiffElement(List<int> A, int B)
        {
            if (A.Count == 1) return 0;

            HashSet<int> hs = new HashSet<int>();

            for (int i = 0; i < A.Count; i++)
            {
                if (B > 0 && hs.Contains(A[i]-B))
                    return 1;

                hs.Add(A[i]);

                if (B > 0 && hs.Contains(A[i] + B))
                    return 1;
            }

            return B == 0 && A.Count > hs.Count ? 1 : 0;

        }
    }
}
