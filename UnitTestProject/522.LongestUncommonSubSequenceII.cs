using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest522
    {
        [TestMethod]
        public void TestLongestUncommonSubSequenceII()
        {
            Assert.IsTrue(FindLUSlength(new[] { "aabbcc", "aabbcc", "cb", "abc" }) == 2);
            Assert.IsTrue(FindLUSlength(new[] { "aba", "cdc", "abd" }) == 3);
            Assert.IsTrue(FindLUSlength(new[] { "aba", "cdc", "abac" }) == 4);
            Assert.IsTrue(FindLUSlength(new[] { "aba", "cdc", "1234" }) == 4);
            Assert.IsTrue(FindLUSlength(new[] { "aba", "cdc", "aba" }) == 3);
            Assert.IsTrue(FindLUSlength(new[] { "aba", "aba", "aba" }) == -1);
            Assert.IsTrue(FindLUSlength(new[] { "aba", "aba", "c" }) == 1);
            Assert.IsTrue(FindLUSlength(new[] { "aba", "aba", "a" }) == -1);
        }

        public int FindLUSlength(string[] strs)
        {
            // 字符串 计算出现的次数
            //出现次数为1的最长的一个字符串

            Dictionary<string, int> countDic = new Dictionary<string, int>();
            foreach (var sub in strs)
            {
                if (countDic.ContainsKey(sub)) { continue; }

                int count = 0;
                foreach (var checkStr in strs)
                {
                    if (CheckSub(checkStr,sub))
                    {
                        count++;
                    }
                }
                countDic.Add(sub, count);
            }

            var lusLength = -1;
            foreach (var k in countDic.Keys)
            {
                Console.WriteLine("Key=" + k + ",count=" + countDic[k]);
                if (countDic[k] == 1)
                {
                    lusLength = k.Length > lusLength ? k.Length : lusLength;
                }
            }
            return lusLength;
        }

        private bool CheckSub(string checkStr, string sub)
        {
            int i = 0;
            foreach (var c in checkStr)
            {
                if (sub[i] == c) i++;
                if (i == sub.Length) break;
            }
            return i == sub.Length;
        }
    }
}
