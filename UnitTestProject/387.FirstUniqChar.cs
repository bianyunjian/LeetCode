using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest387
    {
        [TestMethod]
        public void TestFirstUniqChar()
        {
            Assert.IsTrue(FirstUniqChar("") == -1);
            Assert.IsTrue(FirstUniqChar("leetcode") == 0);
            Assert.IsTrue(FirstUniqChar("loveleetcode" ) == 2);
             
        }

        /// <summary>
        /// ��һ�����ظ����ַ���index
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int FirstUniqChar(string s)
        {
            var charArray = new int[256];
            //ͳ�� �����ַ�����
            for (int i = 0; i < s.Length; i++)
            {
                charArray[s[i]] = charArray[s[i]] + 1; 
            }
            //��һ���ַ�����=1��index
            for (int i = 0; i < s.Length; i++)
            {
                if (charArray[s[i]] == 1) return i; 
            }
            return -1;
        }
         
        
    }
}
