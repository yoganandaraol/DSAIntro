using System;
using System.Collections.Generic;

namespace _099_IsGivenSudokuMatrixValid
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputA = new List<string> { 
                "53..7....", 
                "6..195...", 
                ".98....6.", 
                "8...6...3", 
                "4..8.3..1", 
                "7...2...6", 
                ".6....28.", 
                "...419..5", 
                "....8..79"
            };
            Console.WriteLine(IsGivenSudokuValid(inputA) == 1? "Passed":"Failed");

            inputA = new List<string> {
                "53..7....",
                "6..195...",
                ".98....6.",
                "8...6...3",
                "4..8.3..1",
                "7...2...6",
                ".6....28.",
                "...419..5",
                "....8..73"
            };
            Console.WriteLine(IsGivenSudokuValid(inputA) == 0 ? "Passed" : "Failed");
        }

        static int IsGivenSudokuValid(List<string> A)
        {
            HashSet<char> hsLeft = new HashSet<char>();
            HashSet<char> hsMiddle = new HashSet<char>();
            HashSet<char> hsRight = new HashSet<char>();
            int lCount = 0, mCount = 0, rCount = 0;

            for (int i = 0; i < A.Count; i++)
            {
                // Check row has valid elements
                HashSet<char> hs = new HashSet<char>();
                int itemCount = 0;
                foreach (var item in A[i])
                {
                    if (item != '.')
                    {
                        itemCount++;
                        hs.Add(item);
                    }
                }
                if (hs.Count != itemCount)
                    return 0;

                // Check cols has valid elements
                hs = new HashSet<char>();
                itemCount = 0;
                foreach (var item in A)
                {
                    if (item[i] != '.')
                    {
                        itemCount++;
                        hs.Add(item[i]);
                    }
                }
                if (hs.Count != itemCount)
                    return 0;

                
                if (i / 3 == 0)
                {
                    SetElements(A, i, hsLeft, hsMiddle, hsRight, ref lCount, ref mCount, ref rCount);
                }

                if (i == 2)
                {
                    if (!Validate(ref hsLeft, ref hsMiddle, ref hsRight, ref lCount, ref mCount, ref rCount))
                        return 0;
                }
                

                if (i / 3 == 1)
                {
                    SetElements(A, i, hsLeft, hsMiddle, hsRight, ref lCount, ref mCount, ref rCount);
                }

                if (i == 5)
                {
                    if (!Validate(ref hsLeft, ref hsMiddle, ref hsRight, ref lCount, ref mCount, ref rCount))
                        return 0;
                }
                

                if (i / 3 == 2)
                {
                    SetElements(A, i, hsLeft, hsMiddle, hsRight, ref lCount, ref mCount, ref rCount);
                }
                if (i == 8)
                {
                    if (!Validate(ref hsLeft, ref hsMiddle, ref hsRight, ref lCount, ref mCount, ref rCount))
                        return 0;
                }
            }
            return 1;
        }

        private static bool Validate(ref HashSet<char> hsLeft, ref HashSet<char> hsMiddle, ref HashSet<char> hsRight, ref int lCount, ref int mCount, ref int rCount)
        {
            if (hsLeft.Count == lCount && hsRight.Count == rCount && hsMiddle.Count == mCount)
            {
                lCount = 0;
                mCount = 0;
                rCount = 0;
                hsLeft = new HashSet<char>();
                hsMiddle = new HashSet<char>();
                hsRight = new HashSet<char>();
                return true;
            }
            return false;
        }

        private static void SetElements(List<string> A, int i, HashSet<char> hsLeft, HashSet<char> hsMiddle, HashSet<char> hsRight, ref int l, ref int m, ref int r)
        {
            for (int j = 0; j < A[i].Length; j++)
            {
                switch (j / 3)
                {
                    case 0:
                        if (A[i][j] != '.')
                        {
                            hsLeft.Add(A[i][j]);
                            l++;
                        }
                        break;
                    case 1:
                        if (A[i][j] != '.')
                        {
                            hsMiddle.Add(A[i][j]);
                            m++;
                        }
                        break;
                    case 2:
                        if (A[i][j] != '.')
                        {
                            hsRight.Add(A[i][j]);
                            r++;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        //static int IsGivenSudokuValidV1(List<string> A)
        //{
        //    int[][] r;
        //    int[][] c;
        //    int[][][] s;
        //    r = new int[9][];
        //    c = new int[9][];
        //    for (int i = 0; i < 9; i++)
        //    {
        //        r[i] = new int[9];
        //        c[i] = new int[9];
        //    }

        //    s = new int[3][][];
        //    for (int i = 0; i < 3; i++)
        //    {
        //        s[i] = new int[3][];
        //        for (int j = 0; j < 3; j++)
        //        {
        //            s[i][j] = new int[9];
        //        }
        //    }

        //    int number;
        //    for (int i = 0; i < 9; i++)
        //    {
        //        for (int j = 0; j < 9; j++)
        //        {
        //            if (board[i][j] > '0' && board[i][j] <= '9')
        //            {
        //                number = (int)board[i][j] - (int)'1';
        //                if (r[i][number] > 0) return 0;
        //                r[i][number] = 1;
        //                if (c[j][number] > 0) return 0;
        //                c[j][number] = 1;
        //                if (s[i / 3][j / 3][number] > 0) return 0;
        //                s[i / 3][j / 3][number] = 1;
        //            }
        //        }
        //    }
        //    return 1;
        //}
    }
}
