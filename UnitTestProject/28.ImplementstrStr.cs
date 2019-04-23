using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest28
    {
        [TestMethod]
        public void TestStrStr()
        { 
            Assert.IsTrue(StrStr("mississippi", "issip") == 4);
            Assert.IsTrue(StrStr("aaa", "aaaa") == -1);

            Assert.IsTrue(StrStr("", "") == 0);
            Assert.IsTrue(StrStr("", "1") == -1);
            Assert.IsTrue(StrStr("hello", "") == 0);

            Assert.IsTrue(StrStr("hello", "ll") == 2);

            Assert.IsTrue(StrStr("aaaaa", "bba") == -1);

            Assert.IsTrue(StrStr("hellohello", "ll") == 2);

        }
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle)) return 0;
            if (needle == haystack) return 0;

            if (string.IsNullOrEmpty(haystack)) return -1;
            if (needle.Length > haystack.Length) return -1;
             
            for (int i = 0; i < haystack.Length; i++)
            {
                if (i + needle.Length > haystack.Length)
                {
                    return -1;
                }
                if (haystack[i] == needle[0])
                {
                    var findIndex = i;
                    for (int j = 0; j < needle.Length; j++)
                    {
                        if (haystack[i + j] != needle[j])
                        {
                            findIndex = -1;
                            break;
                        }
                    }
                    if(findIndex>-1)return findIndex;
                }
                
            }
            return -1;
        }
    }
}
