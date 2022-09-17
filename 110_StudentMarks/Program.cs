using System;
using System.Collections.Generic;
using System.Linq;

namespace _110_StudentMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = new List<string> { "xsdf85", "hsdf85", "a3", "sb34", "c100" };
            var output = solve(inputA);

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }

        public static List<string> solve(List<string> A)
        {
            Dictionary<string, StudentCard> res = new Dictionary<string, StudentCard>();
            List<string> output = new List<string>();
            foreach (var item in A)
            {
                int temp = 0;
                int marks = 0;
                string name = "";

                for (int i = 1; i < item.Length; i++)
                {
                    if (int.TryParse(item.Substring(item.Length - i, i), out temp))
                    {
                        name = item.Substring(0, item.Length - i);
                        marks = temp;
                    }
                }

                res.Add(item, new StudentCard(name, marks));
            }

            var result = res.OrderByDescending(x => x.Value.marks).ThenBy(x => x.Value.name);
            foreach (var item in result)
            {
                output.Add(item.Key);
            }

            return output;
        }

        class StudentCard
        {
            public string name;
            public int marks;
            public StudentCard(string name, int marks)
            {
                this.name = name;
                this.marks = marks;
            }
        }
    }
}
