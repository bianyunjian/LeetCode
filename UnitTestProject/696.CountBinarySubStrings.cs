using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest696
    {
        [TestMethod]
        public void TestCountBinarySubStrings()
        {
            Assert.IsTrue(CountBinarySubstrings("1") == 0);
            Assert.IsTrue(CountBinarySubstrings("0") == 0);
            Assert.IsTrue(CountBinarySubstrings("10") == 1);
            Assert.IsTrue(CountBinarySubstrings("01") == 1);
            Assert.IsTrue(CountBinarySubstrings("0011") == 2);
            Assert.IsTrue(CountBinarySubstrings("0110") == 2);
            Assert.IsTrue(CountBinarySubstrings("00110011") == 6);
            Assert.IsTrue(CountBinarySubstrings("10101") == 4);
        }
        public int CountBinarySubstrings(string s)
        {
            int zeroCount = 0, oneCount = 0, result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0)
                {
                    if (s[i] == '0')
                    {
                        zeroCount++;
                    }
                    else
                    {
                        oneCount++;
                    }
                }
                else
                {
                    if (s[i] == '0')
                    {
                        if (s[i - 1] == '0')
                        {
                            //previous is 0 
                            zeroCount++;

                            //may be have '1100'
                            if (oneCount >= zeroCount)
                            {
                                result++;
                            }
                        }
                        else
                        {
                            //previous is 1 
                            zeroCount = 1;

                            //must have '10'
                            result++;
                        }

                    }
                    else if (s[i] == '1')
                    {
                        if (s[i - 1] == '1')
                        {
                            //previous is 1 
                            oneCount++;

                            //may be have '0011'
                            if (zeroCount >= oneCount)
                            {
                                result++;
                            }
                        }
                        else
                        {
                            //previous is 0 
                            oneCount = 1;

                            //must have '01'
                            result++;
                        }
                    }

                }
            }
            return result;
        }

    }
}
