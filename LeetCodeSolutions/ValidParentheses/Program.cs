using System;
using System.Collections.Generic;

namespace ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution("()"));
            Console.WriteLine(Solution("()[]{}"));
            Console.WriteLine(Solution("(]"));
        }

        static bool Solution(string s)
        {
            Stack<char> stack = new Stack<char>();

            if (s.Length == 1)
                return false;

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                        return false;
                    if (c == ')' && stack.Peek() != '(')
                        return false;
                    if (c == ']' && stack.Peek() != '[')
                        return false;
                    if (c == '}' && stack.Peek() != '{')
                        return false;

                    stack.Pop();
                }
            }

            return stack.Count == 0 ? true : false;
        }
    }
}
