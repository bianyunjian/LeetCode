using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest125
    {
        [TestMethod]
        public void TestValidPalindrome()
        {
            Assert.IsTrue(IsPalindrome("1a2") == false);
            Assert.IsTrue(IsPalindrome(".,") == true);

            Assert.IsTrue(IsPalindrome(""));
            Assert.IsTrue(IsPalindrome("  "));
            Assert.IsTrue(IsPalindrome("A"));
            Assert.IsTrue(IsPalindrome("AA"));
            Assert.IsTrue(IsPalindrome("A A"));
            Assert.IsTrue(IsPalindrome("A man, a plan, a canal: Panama"));
            Assert.IsTrue(IsPalindrome("race a car") == false);
        }

        public bool IsPalindrome(string s)
        {
            s = s.Trim();
            if (string.IsNullOrEmpty(s)) return true;

            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                if (IsAlphanumeric(s[left]) == false)
                {
                    left++;
                }
                else if (IsAlphanumeric(s[right]) == false)
                {
                    right--;
                }
                else if ((s[left] + 32 - 'a') % 32 != (s[right] + 32 - 'a') % 32)
                {
                    return false;
                }
                else
                {
                    left++;
                    right--;
                }
            }
            return true;

        }

        private bool IsAlphanumeric(char c)
        {
            if (c >= '0' && c <= '9') return true;
            if (c >= 'A' && c <= 'Z') return true;
            if (c >= 'a' && c <= 'z') return true;
            return false;
        }
    }
}
