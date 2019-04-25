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
        /// ��ʾ��magazine�п����ҵ��㹻���ַ�, �����ransomNote
        /// Key: ��ĸ����Ҫ�㹻; ˳��Ҫ��һ��
        /// </summary>
        /// <param name="ransomNote"></param>
        /// <param name="magazine"></param>
        /// <returns></returns>
        public bool CanConstruct_Dic(string ransomNote, string magazine)
        {
            var charDic = new Dictionary<char, int>();
            //ͳ�� �����ַ�����
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
            //�����ҵ����ַ�, ����-1
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
        /// ��ʾ��magazine�п����ҵ��㹻���ַ�, �����ransomNote
        /// Key: ��ĸ����Ҫ�㹻; ˳��Ҫ��һ��
        /// </summary>
        /// <param name="ransomNote"></param>
        /// <param name="magazine"></param>
        /// <returns></returns>
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var charArray = new int[256];
            //ͳ�� �����ַ�����
            for (int i = 0; i < magazine.Length; i++)
            {
                charArray[magazine[i]] = charArray[magazine[i]] + 1;

            }
            //�����ҵ����ַ�, ����-1
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
