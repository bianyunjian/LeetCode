using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest38
    {
        [TestMethod]
        public void TestCountAndSay()
        {
            Assert.IsTrue(CountAndSay(6) == "312211");
            Assert.IsTrue(CountAndSay(1) == "1");
            Assert.IsTrue(CountAndSay(2) == "11");
            Assert.IsTrue(CountAndSay(3) == "21");
            Assert.IsTrue(CountAndSay(4) == "1211");
            Assert.IsTrue(CountAndSay(5) == "111221");

        }
        public string CountAndSay(int n)
        {
            if (n <= 0) return "";

            var str = "1";
            for (int loopIndex = 0; loopIndex < n - 1; loopIndex++)
            {
                var newStr = "";
                for (int i = 0; i < str.Length; i++)
                {
                    var numberCount = 1;
                    while ((i + 1) < str.Length && str[i] == str[i + 1])
                    {
                        numberCount++;
                        i++;
                    }
                    newStr += numberCount.ToString() + str[i];
                }
                str = newStr;
                Console.WriteLine(str);
            }
            return str;
        }
    }
}
