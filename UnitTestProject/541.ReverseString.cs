using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest541
    {
        [TestMethod]
        public void TestReverseString()
        {
            Assert.IsTrue(ReverseStr("abcdefg", 2) == "bacdfeg");
            Assert.IsTrue(ReverseStr("abcdefghijklmn", 3) == "cbadefihgjklnm");
            Assert.IsTrue(ReverseStr("abcdefghijklmnop", 3) == "cbadefihgjklonmp");
        }

        public string ReverseStr(string s, int k)
        {
            var resultChar = new char[s.Length];

            int leftIndex = 0, rightIndex = 0;
            for (int i = 0; i < s.Length;)
            {
                leftIndex = i;
                if (s.Length - i <= k)
                {
                    rightIndex = s.Length - 1;
                }
                else
                {
                    rightIndex = i + k - 1;
                }

                for (int j = 0; j <= (rightIndex - leftIndex); j++)
                {
                    resultChar[leftIndex + j] = s[rightIndex - j];
                }

                for (int p = rightIndex + 1; p <= (rightIndex + k) && p < s.Length; p++)
                {
                    resultChar[p] = s[p];
                }
                Console.WriteLine(new string(resultChar));
                i += 2 * k;
            }

            Console.WriteLine(new string(resultChar));
            return new string(resultChar);
        }

    }
}
