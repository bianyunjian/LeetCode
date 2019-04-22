using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest14
    {
        [TestMethod]
        public void TestLongestCommonPrefix()
        {
            Assert.IsTrue(LongestCommonPrefix(new[] { "" }) == "");

            Assert.IsTrue(LongestCommonPrefix(new[] { "flower" }) == "flower");

            Assert.IsTrue(LongestCommonPrefix(new[] { "flower", "flow", "flight" }) == "fl");

            Assert.IsTrue(LongestCommonPrefix(new[] { "dog", "racecar", "car" }) == "");

        }
        public string LongestCommonPrefix(string[] strs)
        {

            if (strs.Length == 0) return string.Empty;
            if (strs.Length == 1) return strs[0];
            var minLengthStrIndex = 0;
            var minLength = 0;
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length < minLength)
                {
                    minLength = strs[i].Length;
                    minLengthStrIndex = i;
                }
            }
            var prefix = string.Empty;
            for (int charIndex = 0; charIndex < strs[minLengthStrIndex].Length; charIndex++)
            {
                var currentChar = strs[minLengthStrIndex][charIndex];
                for (int strIndex = 0; strIndex < strs.Length; strIndex++)
                {
                    if (strIndex == minLengthStrIndex) continue;
                    if (strs[strIndex].Length <= charIndex || strs[strIndex][charIndex] != currentChar)
                    {
                        return prefix;
                    }
                }
                prefix += currentChar;
            }
            return prefix;
        }
    }
}
