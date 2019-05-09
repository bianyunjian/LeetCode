using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest520
    {
        [TestMethod]
        public void TestDetectCapitalUse()
        {
            Assert.IsTrue(DetectCapitalUse("USA"));

            Assert.IsTrue(DetectCapitalUse("Google"));

            Assert.IsTrue(DetectCapitalUse("leetcode"));

            Assert.IsTrue(DetectCapitalUse("leetcodE") == false);
            Assert.IsTrue(DetectCapitalUse("leetCode") == false);

            Assert.IsTrue(DetectCapitalUse("LeetCode") == false);
        }

        /// <summary>
        /// 
        /// word[0] =upperCase & word[1]= upperCase : left should be upperCase
        /// word[0] =upperCase & word[1]= lowerCase : left should be lowerCase
        /// word[0] =lowerCase  : left should be lowerCase
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>

        public bool DetectCapitalUse(string word)
        {
            if (word.Length <= 1) return true;

            var firstChar = word[0];
            var secondChar = word[1];
            bool upperCase = false;
            if (IsUpperCase(firstChar))
            {

                upperCase = IsUpperCase(secondChar);
            }
            else
            {
                upperCase = false;
            }

            for (int i = 1; i < word.Length; i++)
            {
                if (upperCase && IsUpperCase(word[i]) == false)
                {
                    return false;

                }
                else if (upperCase == false && IsUpperCase(word[i]) == true)
                {
                    return false;
                }

            }
            return true;
        }

        private bool IsUpperCase(char firstChar)
        {
            return firstChar >= 'A' && firstChar <= 'Z';
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool DetectCapitalUse2(string word)
        {
            if (word.Length <= 1) return true;

            var count = 0;
            foreach (var w in word)
            {
                if (IsUpperCase(w))
                {
                    count++;
                }
            }

            return (count == 0 || count == word.Length || (count == 1 && IsUpperCase(word[0])));
        }
    }
}
