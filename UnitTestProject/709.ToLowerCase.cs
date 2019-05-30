using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest709
    {
        [TestMethod]
        public void TestToLowerCase()
        {
            Assert.IsTrue(ToLowerCase("abc") == "abc");
            Assert.IsTrue(ToLowerCase("ABC") == "abc");
            Assert.IsTrue(ToLowerCase("abc") == "abc");
            Assert.IsTrue(ToLowerCase("abc1234!@#") == "abc1234!@#");

        }
        public string ToLowerCase(string str)
        {
            var lowerchars = str.ToCharArray();
            for (int i = 0; i < lowerchars.Length; i++)
            {
                if (lowerchars[i] >= 'A' && lowerchars[i] <= 'Z')
                {
                    //lowerchars[i] = (char)(lowerchars[i] +32);
                    lowerchars[i] = (char)(lowerchars[i] | 0x20);
                }
            }

            return new string(lowerchars);

        }
    }
}
