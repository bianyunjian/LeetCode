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
            Assert.IsTrue(CountSegments(" Hello, my name is John ") == 5);
            Assert.IsTrue(CountSegments("") == 0);
            Assert.IsTrue(CountSegments(" ") == 0);
            Assert.IsTrue(CountSegments(" 1") == 1);
            Assert.IsTrue(CountSegments("1 ") == 1);
            Assert.IsTrue(CountSegments(" 1 ") == 1);

            Assert.IsTrue(CountSegments(" 1 2 ") == 2);

            
        }
        public int CountSegments(string s)
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
