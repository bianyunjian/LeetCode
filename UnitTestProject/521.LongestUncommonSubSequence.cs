using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest521
    {
        [TestMethod]
        public void TestLongestUncommonSubSequence()
        {
            Assert.IsTrue(FindLUSlength("aba", "cdc") == 3);


        }

        public int FindLUSlength(string a, string b)
        {
            if (string.Equals(a, b))
            {
                return -1;
            }

            return a.Length > b.Length ? a.Length : b.Length;
        }
    }
}
