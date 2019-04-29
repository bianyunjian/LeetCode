using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest434
    {
        [TestMethod]
        public void TestNumberOfSegmentInAString()
        {
            Assert.IsTrue(countSegment(" Hello, my name is John ") == 5);
            Assert.IsTrue(countSegment("") == 0);
            Assert.IsTrue(countSegment(" ") == 0);
            Assert.IsTrue(countSegment(" 1") == 1);
            Assert.IsTrue(countSegment("1 ") == 1);
            Assert.IsTrue(countSegment(" 1 ") == 1);

            Assert.IsTrue(countSegment(" 1 2 ") == 2);

            
        }
        public int countSegment(string s)
        {
            var count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0 || s[i - 1] == ' ')
                {
                    if (s[i] != ' ')
                    {
                        count++;
                    }
                }

            }

            return count;
        }
    }
}
