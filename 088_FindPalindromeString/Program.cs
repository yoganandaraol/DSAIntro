using System;

namespace _088_FindPalindromeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestPalindromicSubstring("aarevveraa") == 10 ? "Passed" : "Failed");
            Console.WriteLine(LongestPalindromicSubstring("aareveraaaa") == 9 ? "Passed" : "Failed");
            Console.WriteLine(LongestPalindromicSubstring("aaaareveraa") == 9 ? "Passed" : "Failed");
            //Console.WriteLine(LongestPalindromicSubstring("revveraa") == 6 ? "Passed" : "Failed");
            //Console.WriteLine(LongestPalindromicSubstring("aarevver") == 6 ? "Passed" : "Failed");
        }

        static int LongestPalindromeLength(string s, int lIndex, int rIndex)
        {
            int count = 0;

            if (lIndex == rIndex)
            {
                for (int i = 0; i < s.Length / 2; i++)
                {
                    if (s[i - 1] == s[i + 1])
                    {
                        count++;
                        continue;
                    }
                    break;

                }
            }



            return count;
        }

        static int LongestPalindromicSubstring(string s)
        {
            int maxLen = 0;
            int count = s.Length % 2 == 0 ? 0 : 1;
            int sIndex = s.Length % 2 == 0 ? (s.Length - 1) / 2 : s.Length / 2;

            Console.WriteLine(s[sIndex]);
            int iteration;
            if (s.Length % 2 > 0)
            {
                for (int i = sIndex; i >= 0; i--)
                {
                    iteration = 1;
                    while (i - iteration >= 0)
                    {
                        if (s[i - iteration] == s[i + iteration])
                        {
                            count += 2;
                            maxLen = Math.Max(maxLen, count);
                        }
                        else break;
                        iteration++;
                    }
                }

                for (int i = sIndex + 1; i < s.Length; i++)
                {
                    iteration = 1;
                    count = s.Length % 2 == 0 ? 0 : 1;
                    while (i + iteration < s.Length)
                    {
                        if (s[i - iteration] == s[i + iteration])
                        {
                            count += 2;
                            maxLen = Math.Max(maxLen, count);
                        }
                        else break;
                        iteration++;
                    }

                }

            }
            else
            {
                for (int i = sIndex; i >= 0; i--)
                {
                    iteration = 1;
                    int lIndex = sIndex, rIndex = lIndex + 1;
                    while (i - iteration >= 0)
                    {
                        Console.WriteLine($"\t{s[lIndex - iteration]}\t{s[rIndex + iteration]}");
                        if (s[lIndex - iteration] == s[rIndex + iteration])
                        {
                            count += 2;
                            maxLen = Math.Max(maxLen, count);
                        }
                        else break;
                        iteration++;
                    }
                    sIndex--;
                }

                for (int i = sIndex + 1; i < s.Length-1; i++)
                {
                    iteration = 1;
                    int lIndex = sIndex+1, rIndex = lIndex + 1;
                    while (i - iteration >= 0)
                    {
                        Console.WriteLine($"\t{s[lIndex - iteration]}\t{s[rIndex + iteration]}");
                        if (s[lIndex - iteration] == s[rIndex + iteration])
                        {
                            count += 2;
                            maxLen = Math.Max(maxLen, count);
                        }
                        else break;
                        iteration++;
                    }


                    count = s.Length % 2 == 0 ? 0 : 1;
                    while (i + iteration < s.Length)
                    {
                        Console.WriteLine($"\t{s[i - iteration]}\t{s[i + iteration]}");
                        if (s[i - iteration] == s[i + iteration])
                        {
                            count += 2;
                            maxLen = Math.Max(maxLen, count);
                        }
                        else break;
                        iteration++;
                    }

                }






                
            }


            Console.WriteLine("----------------------------------");


            Console.WriteLine(maxLen);
            return maxLen;
        }
    }
}

