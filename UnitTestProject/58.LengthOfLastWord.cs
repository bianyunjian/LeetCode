using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest58
    {
        [TestMethod]
        public void TestLengthOfLastWord()
        {
            Assert.IsTrue(LengthOfLastWord("") == 0);
            Assert.IsTrue(LengthOfLastWord(" ") == 0);
            Assert.IsTrue(LengthOfLastWord("Hello ") == 5);
            Assert.IsTrue(LengthOfLastWord("Hello") == 5);
            Assert.IsTrue(LengthOfLastWord("Hello World ") == 5);
            Assert.IsTrue(LengthOfLastWord(" Hello World ") == 5);

            Assert.IsTrue(LengthOfLastWord(" World") == 5);
            Assert.IsTrue(LengthOfLastWord("Hello World") == 5);


        }
        public int LengthOfLastWord(string s)
        {
            if (s.Length == 0) return 0;

            var lastIndex = -1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    if (lastIndex == -1)
                    {
                        continue;
                    }
                    else
                    {
                        return lastIndex - i;
                    }
                }
                else
                {
                    if (lastIndex == -1)
                    {
                        lastIndex = i;
                    }
                }
            }
            return lastIndex + 1;
        }
    }
}
