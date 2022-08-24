/*
 * ####################################################################
 * 
 * Problem Description:
 * --------------------
        Given an integer array A of size N. 
        Return 1 if the array can be arranged to form an arithmetic progression, otherwise return 0.

        A sequence of numbers is called an arithmetic progression if the difference between any two consecutive elements is the same.

    Problem Constraints
    -------------------
        2 <= N <= 10^5
        -10^9 <= A[i] <= 10^9

    Output Format
    -------------
        Return 1 if the array can be rearranged to form an arithmetic progression, otherwise return 0.

    Sample Input:
    ------------
        A = [3, 5, 1]

    Sample Output:
    -------------
        1

        Explanation:
            We can reorder the elements as [1,3,5] or [5,3,1] with differences 2 and -2 respectively, between each consecutive elements.

    Sample Input:
    ------------
        A = [2, 4, 1]

    Sample Output:
    -------------
        0
        
        Explanation:
            There is no way to reorder the elements to obtain an arithmetic progression.
 * 
 * ####################################################################
 */

using System;
using System.Collections.Generic;

namespace _079_ArrayElementsWithArthmeticProgression
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = new List<int> { 3, 5, 1 };
            Console.WriteLine(CheckArrayHasArthProgressionElementsV1(inputA) == 1 ? "Passed" : "Failed");
            inputA = new List<int> { 3, 5, 1, 1 };
            Console.WriteLine(CheckArrayHasArthProgressionElementsV1(inputA) == 0 ? "Passed" : "Failed");
            inputA = new List<int> { 2, 4, 1 };
            Console.WriteLine(CheckArrayHasArthProgressionElementsV1(inputA) == 0 ? "Passed" : "Failed");
            inputA = new List<int> { -251, -305, -323, -53, -215, -143, -107, -161, -179, -431, -449, -17, -341, -413, -35, -125, -197, -377, -269, -71, -359, -89, -233, -287, -395 };
            Console.WriteLine(CheckArrayHasArthProgressionElementsV1(inputA) == 1 ? "Passed" : "Failed");
            inputA = new List<int> { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73, 75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99, 101, 103, 105, 107, 109, 111, 113, 115, 117, 119, 121, 123, 125, 127, 129, 131, 133, 135, 137, 139, 141, 143, 145, 147, 149, 151, 153, 155, 157, 159, 161, 163, 165, 167, 169, 171, 173, 175, 177, 179, 181, 183, 185, 187, 189, 191, 193, 195, 197, 199, 201, 203, 205, 207, 209, 211, 213, 215, 217, 219, 221, 223, 225, 227, 229, 231, 233, 235, 237, 239, 241, 243, 245, 247, 249, 251, 253, 255, 257, 259, 261, 263, 265, 267, 269, 271, 273, 275, 277, 279, 281, 283, 285, 287, 289, 291, 293, 295, 297, 299, 301, 303, 305, 307, 309, 311, 313, 315, 317, 319, 321, 323, 325, 327, 329, 331, 333, 335, 337, 339, 341, 343, 345, 347, 349, 351, 353, 355, 357, 359, 361, 363, 365, 367, 369, 371, 373, 375, 377, 379, 381, 383, 385, 387, 389, 391, 393, 395, 397, 399, 401, 403, 405, 407, 409, 411, 413, 415, 417, 419, 421, 423, 425, 427, 429, 431, 433, 435, 437, 439, 441, 443, 445, 447, 449, 451, 453, 455, 457, 459, 461, 463, 465, 467, 469, 471, 473, 475, 477, 479, 481, 483, 485, 487, 489, 491, 493, 495, 497, 499, 501, 503, 505, 507, 509, 511, 513, 515, 517, 519, 521, 523, 525, 527, 529, 531, 533, 535, 537, 539, 541, 543, 545, 547, 549, 551, 553, 555, 557, 559, 561, 563, 565, 567, 569, 571, 573, 575, 577, 579, 581, 583, 585, 587, 589, 591, 593, 595, 597, 599, 601, 603, 605, 607, 609, 611, 613, 615, 617, 619, 621, 623, 625, 627, 629, 631, 633, 635, 637, 639, 641, 643, 645, 647, 649, 651, 653, 655, 657, 659, 661, 663, 665, 667, 669, 671, 673, 675, 677 };
            Console.WriteLine(CheckArrayHasArthProgressionElementsV1(inputA) == 1 ? "Passed" : "Failed");
        }

        static int CheckArrayHasArthProgressionElementsV1(List<int> A)
        {
            A.Sort((a, b) => a.CompareTo(b));
            int diff = A[1] - A[0];

            for (int i = 1; i < A.Count; i++)
            {
                if (A[i] - A[i - 1] == diff) continue;
                else return 0;
            }
            return 1;
        }
    }
}
