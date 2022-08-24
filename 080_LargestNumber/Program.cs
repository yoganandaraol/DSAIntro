/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Given an array A of non-negative integers, arrange them such that they form the largest number.

        Note: 
            The result may be very large, so you need to return a string instead of an integer.

    Problem Constraints
    -------------------
        1 <= len(A) <= 100000
        0 <= A[i] <= 2*10^9

    Output Format
    -------------
        Return a string representing the largest number.

    Sample Input:
    ------------
        A = [3, 30, 34, 5, 9]

    Sample Output:
    -------------
        "9534330"

        Explanation:
            Reorder the numbers to [9, 5, 34, 3, 30] to form the largest number.

    Sample Input:
    ------------
        A = [2, 3, 9, 0]

    Sample Output:
    -------------
        "9320"
        
        Explanation:
            Reorder the numbers to [9, 3, 2, 0] to form the largest number 9320.
 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace _080_LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = new List<int> { 3, 2, 1, 3 };
            Console.WriteLine(ArrangeLargestNumberV1(inputA) == "3321" ? "Passed" : "Failed");
            inputA = new List<int> { 1, 1, 3, 3 };
            Console.WriteLine(ArrangeLargestNumberV1(inputA) == "3311" ? "Passed" : "Failed");
            inputA = new List<int> { 92, 9, 98, 97 };
            Console.WriteLine(ArrangeLargestNumberV1(inputA) == "9989792" ? "Passed" : "Failed");
            inputA = new List<int> { 3, 30, 34, 5, 9 };
            Console.WriteLine(ArrangeLargestNumberV1(inputA) == "9534330" ? "Passed" : "Failed");
            inputA = new List<int> { 0, 0, 0, 0, 0 };
            Console.WriteLine(ArrangeLargestNumberV1(inputA) == "0" ? "Passed" : "Failed");
            inputA = new List<int> { 980, 98, 981 };
            Console.WriteLine(ArrangeLargestNumberV1(inputA) == "98981980" ? "Passed" : "Failed");
            inputA = new List<int> { 29, 298 };
            Console.WriteLine(ArrangeLargestNumberV1(inputA) == "29829" ? "Passed" : "Failed");
            inputA = new List<int> { 980, 674, 250, 359, 98, 969, 143, 379, 363, 106, 838, 923, 969, 880, 997, 664, 152, 329, 975, 377, 995, 943, 369, 515, 722, 302, 496, 124, 692, 993, 341, 785, 400, 113, 302, 563, 121, 230, 358, 911, 437, 438, 494, 599, 168, 866, 689, 444, 684, 365, 470, 176, 910, 204, 324, 657, 161, 884, 623, 814, 231, 694, 399, 126, 426 };
            Console.WriteLine(ArrangeLargestNumberV1(inputA) == "99799599398980975969969943923911910884880866838814785722694692689684674664657623599563515496494470444438437426400399379377369365363359358341329324302302250231230204176168161152143126124121113106" ? "Passed" : "Failed");
            inputA = new List<int> { 782, 240, 409, 678, 940, 502, 113, 686, 6, 825, 366, 686, 877, 357, 261, 772, 798, 29, 337, 646, 868, 974, 675, 271, 791, 124, 363, 298, 470, 991, 709, 533, 872, 780, 735, 19, 930, 895, 799, 395, 905 };
            Console.WriteLine(ArrangeLargestNumberV1(inputA) == "99197494093090589587787286882579979879178278077273570968668667867566465335024704093953663633573372982927126124019124113" ? "Passed" : "Failed");
        }
        static string ArrangeLargestNumber(List<int> A)
        {
            StringBuilder sb = new StringBuilder();
            A.Sort((a, b) => b.ToString().CompareTo(a.ToString()));
            if (A[0] == 0) return "0";
            
            foreach (var item in A)
            {
                sb.Append(item);
            }
            return sb.ToString();
        }

        static string ArrangeLargestNumberV1(List<int> A)
        {
            StringBuilder sb = new StringBuilder();
            A.Sort(new SortForLargeVal());
            if (A[0] == 0) return "0";

            foreach (var item in A)
                sb.Append(item);

            return sb.ToString();
        }
    }

    public class SortForLargeVal : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            string xy = string.Format("{0}{1}", x, y);
            string yx = string.Format("{0}{1}", y, x);
            return yx.CompareTo(xy);
        }
    }
}
