using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest20
    {
        [TestMethod]
        public void TestValidParentheses()
        {
            Assert.IsTrue(IsValid("(])") == false);

            Assert.IsTrue(IsValid("()"));
            Assert.IsTrue(IsValid("()[]{}"));
            Assert.IsTrue(IsValid("(]") == false);
            Assert.IsTrue(IsValid("([)]") == false);
            Assert.IsTrue(IsValid("{[]}") == true);

            Assert.IsTrue(IsValid("]") == false);


        }
        public bool IsValid(string s)
        {
              
            Stack<char> stack = new Stack<char>();

            if (string.IsNullOrEmpty(s)) return true;

            for (int i = 0; i < s.Length; i++)
            {
                var currentChar = s[i];
                if (IsLeftChar(currentChar))
                {
                    stack.Push(currentChar);
                    continue;
                }
                if (stack.Count == 0)
                    return false;

                if (IsRightChar(currentChar))
                {
                    if (stack.Peek() == GetLeftChar(currentChar))
                        stack.Pop();
                    else
                        return false;
                }

            }
            return stack.Count == 0;
        }
        bool IsLeftChar(char c)
        {
            return c == '(' || c == '[' || c == '{';
        }
        bool IsRightChar(char c)
        {
            return c == ')' || c == ']' || c == '}';
        }
        char GetLeftChar(char left)
        {
            if (left == ')') return '(';
            if (left == ']') return '[';
            if (left == '}') return '{';
            return ' ';

        }
    }
}
