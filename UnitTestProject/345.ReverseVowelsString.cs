using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest345
    {
        [TestMethod]
        public void TestReverseVowelsString()
        {
            Assert.IsTrue(ReverseVowels(".,") == ".,");
            Assert.IsTrue(ReverseVowels("hello") == "holle");
            Assert.IsTrue(ReverseVowels("leetcode") == "leotcede");
        }
        public string ReverseVowels(string s)
        {
            if (s == null || s.Length <= 1) return s;

            var chars = s.ToCharArray();
            int left = 0, right = s.Length - 1;
            while (left < right)
            {

                while (isVowels(chars[left]) == false)
                {
                    if (left == chars.Length - 1)
                    {
                        return new string(chars);
                    }
                    left++;
                }
                while (isVowels(chars[right]) == false)
                {
                    if (right == 0)
                    {
                        return new string(chars);
                    }
                    right--;
                }
                if (left >= right || left > chars.Length - 1 || right < 0)
                {
                    break;
                }
                var tempChar = chars[left];
                chars[left] = chars[right];
                chars[right] = tempChar;

                left++;
                right--;
            }
            return new string(chars);
        }
        private bool isVowels(char c)
        {

            var newc = c < 'a' ? (c + 32) : c;
            return newc == 'a' || newc == 'e' || newc == 'o' || newc == 'u' || newc == 'i';
        }
    }
}
