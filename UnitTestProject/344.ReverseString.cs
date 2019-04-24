using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest344
    {
        [TestMethod]
        public void TestReverseString()
        {
            var chars = new char[] { 'h', 'e', 'l', 'l', 'o' ,'o'};
            var oldStr = string.Join("", chars.Select(t => t.ToString()).ToArray());
            ReverseString(chars);
            var reverseStr = string.Join("", chars.Select(t => t.ToString()).ToArray());

            Assert.IsTrue(new string(oldStr.Reverse().ToArray()) == reverseStr);

        }
        public void ReverseString(char[] s)
        {
            if (s == null || s.Length <= 1) return;

            char tempChar;
            for (int i = 0; i < s.Length; i++)
            {
                if (i >= s.Length - 1 - i) return;
                tempChar = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = tempChar;
            }
        }
    }
}
