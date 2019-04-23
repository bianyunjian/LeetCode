using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest67
    {
        [TestMethod]
        public void TestAddBinary()
        {
            Assert.IsTrue(AddBinary("1", "11") == "100");
            Assert.IsTrue(AddBinary("11", "1") == "100");
            Assert.IsTrue(AddBinary("11", "11") == "110");
            Assert.IsTrue(AddBinary("111", "110") == "1101");
        }

        public string AddBinary(string a, string b)
        {
            var result = string.Empty;
            var baseStr = a.Length > b.Length ? a : b;
            var plusStr = a.Length > b.Length ? b : a;
            var carry = 0;
            for (int i = 0; i < baseStr.Length; i++)
            {
                var baseNum = int.Parse(baseStr[baseStr.Length - 1 - i].ToString());
                var plusNum = 0;
                if (i < plusStr.Length)
                {
                    plusNum = int.Parse(plusStr[plusStr.Length - 1 - i].ToString());
                }

                var current = baseNum + plusNum + carry;
                carry = current / 2;
                current = current % 2;

                result = current.ToString() + result;
            }
            if (carry == 1)
            {
                result = "1" + result;
            }

            return result;
        }

    }
}
