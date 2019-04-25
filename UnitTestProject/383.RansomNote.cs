using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest383
    {
        [TestMethod]
        public void TestRansomNote()
        {
            Assert.IsTrue(CanConstruct("a", "") == false);
            Assert.IsTrue(CanConstruct("", "") == true);
            Assert.IsTrue(CanConstruct("", "a") == true);
            Assert.IsTrue(CanConstruct("a", "b") == false);
            Assert.IsTrue(CanConstruct("aa", "a") == false);
            Assert.IsTrue(CanConstruct("ab", "bca") == true);
            Assert.IsTrue(CanConstruct("aab", "ababab") == true);
        }

        /// <summary>
        /// 表示在magazine中可以找到足够的字符, 来组成ransomNote
        /// Key: 字母个数要足够; 顺序不要求一样
        /// </summary>
        /// <param name="ransomNote"></param>
        /// <param name="magazine"></param>
        /// <returns></returns>
        public bool CanConstruct_Dic(string ransomNote, string magazine)
        {
            var charDic = new Dictionary<char, int>();
            //统计 所有字符数量
            for (int i = 0; i < magazine.Length; i++)
            {
                if (charDic.ContainsKey(magazine[i]))
                {
                    charDic[magazine[i]] = charDic[magazine[i]] + 1;
                }
                else
                {
                    charDic.Add(magazine[i], 1);
                }
            }
            //按照找到的字符, 数量-1
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (charDic.ContainsKey(ransomNote[i]) == false)
                {
                    return false;
                }
                else
                {
                    if (charDic[ransomNote[i]] <= 0) return false;

                    charDic[ransomNote[i]] = charDic[ransomNote[i]] - 1;
                }
            }

            return true;
        }

        /// <summary>
        /// 表示在magazine中可以找到足够的字符, 来组成ransomNote
        /// Key: 字母个数要足够; 顺序不要求一样
        /// </summary>
        /// <param name="ransomNote"></param>
        /// <param name="magazine"></param>
        /// <returns></returns>
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var charArray = new int[256];
            //统计 所有字符数量
            for (int i = 0; i < magazine.Length; i++)
            {
                charArray[magazine[i]] = charArray[magazine[i]] + 1;

            }
            //按照找到的字符, 数量-1
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (charArray[ransomNote[i]]==0)
                {
                    return false;
                }
                charArray[ransomNote[i]] = charArray[ransomNote[i]] - 1;
            }

            return true;
        }
    }
}
