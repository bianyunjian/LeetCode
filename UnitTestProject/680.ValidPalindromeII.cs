using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest680
    {
        [TestMethod]
        public void TestValidPalindromeII()
        {
            Assert.IsTrue(ValidPalindrome("ebcbbececabbacecbbcbe"));

            Assert.IsTrue(ValidPalindrome("a"));
            Assert.IsTrue(ValidPalindrome("aba"));
            Assert.IsTrue(ValidPalindrome("abca"));

            Assert.IsTrue(ValidPalindrome("ab"));
            Assert.IsTrue(ValidPalindrome("abbca"));
            Assert.IsTrue(ValidPalindrome("abcda") == false);
            Assert.IsTrue(ValidPalindrome("abbcda") == false);
        }
        public bool ValidPalindrome(string s)
        {
            var left = 0;
            var right = s.Length - 1;
            while (left < right)
            {
                if (s[left] == s[right])
                {
                    left++;
                    right--;
                    continue;
                }
                //³¢ÊÔÓÒ±ßÒÆ³ýÒ»¸ö
                var valid = IsValid(s, left, right - 1);
                if (valid == false)
                {
                    //³¢ÊÔ×ó±ßÒÆ³ýÒ»¸ö
                    valid = IsValid(s, left + 1, right);
                }

                return valid;


            }
            return true;
        }

        private bool IsValid(string s, int left, int right)
        {
            while (left < right)
            {
                if (s[left] == s[right])
                {
                    left++;
                    right--;
                    continue;
                }
                return false;
            }
            return true;
        }

    }
}
