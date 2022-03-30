using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _20ValidParentheses
    {
        public bool IsValid_Stack(string s)
        {
            var stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i]=='[' || s[i] == '{')
                    stack.Push(s[i]);
                else if (stack.Count > 0)
                {
                    var c = stack.Peek();
                    if (s[i] == ')' && c == '(' ||
                        s[i] == ']' && c == '[' ||
                        s[i] == '}' && c == '{')
                        stack.Pop();
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            if (stack.Count == 0)
                return true;
            else
                return false;
        }

        public bool IsValid(string s)
        {
            var foundPair = false;
            while (s.Length > 0)
            {
                foundPair = false;
                for (int i = 0; i < s.Length; i++)
                {
                    if (i+1 < s.Length && IsPair(s[i],s[i + 1]))
                    {
                        s = s.Substring(0, i) + s.Substring(i + 2);
                        i--;
                        foundPair = true;
                    }
                }
                if (!foundPair)
                    return false;
            }
            return true;
        }

        private bool IsPair(char c, char c1)
        {
            return c == '(' && c1 == ')' ||
                   c == '[' && c1 == ']' ||
                   c == '{' && c1 == '}';
        }
    }
}
