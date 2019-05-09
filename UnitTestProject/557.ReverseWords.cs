using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest557
    {
        [TestMethod]
        public void TestReverseWords()
        {
            Assert.IsTrue(ReverseWords("Let's take LeetCode contest") == "s'teL ekat edoCteeL tsetnoc");

            
        }

        public string ReverseWords(string s)
        {
            var resultChar = new char[s.Length];

            int leftIndex = 0, rightIndex = 0;
            for (int i = 0; i < s.Length;)
            {
                leftIndex = i;
                while (s[leftIndex] == ' ')
                {
                    resultChar[leftIndex] = ' ';
                    leftIndex++;
                   
                }

                rightIndex = leftIndex + 1;
                while (rightIndex < s.Length)
                {
                    if (s[rightIndex] == ' ')
                    {
                        rightIndex = rightIndex - 1;
                        break;
                    }
                    rightIndex++;
                }
                rightIndex = Math.Min(rightIndex, s.Length - 1);
                for (int j = 0; j <= (rightIndex - leftIndex); j++)
                {
                    resultChar[leftIndex + j] = s[rightIndex - j];
                }

                i = rightIndex + 1;
            }

            Console.WriteLine(new string(resultChar));
            return new string(resultChar);
        }

    }
}
