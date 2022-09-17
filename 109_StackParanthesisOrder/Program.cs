using System;
using System.Collections.Generic;

namespace _109_StackParanthesisOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsParanthesisOrderValid("{([])}") == 1 ? "Passed" : "Failed");
            Console.WriteLine(IsParanthesisOrderValid("(){") == 0 ? "Passed" : "Failed");
            Console.WriteLine(IsParanthesisOrderValid("()[]") == 1 ? "Passed" : "Failed"); 
            Console.WriteLine(IsParanthesisOrderValid("))))))))") == 0 ? "Passed" : "Failed"); 
        }

        static int IsParanthesisOrderValid(string A)
        {
            Stack<char> s = new Stack<char>();
            int openCount = 0;
            foreach (var item in A)
            {
                if (item == '{' || item == '[' || item == '(')
                {
                    s.Push(item);
                    openCount++;
                }
                else if (item == '}' && s.Count > 0 && Convert.ToChar(s.Pop()) != '{')
                    return 0;
                else if (item == ']' && s.Count > 0 && Convert.ToChar(s.Pop()) != '[')
                    return 0;
                else if (item == ')' && s.Count > 0 && Convert.ToChar(s.Pop()) != '(')
                    return 0;
            }

            return openCount > 0 && s.Count == 0 ? 1 : 0;
        }
    }
}
