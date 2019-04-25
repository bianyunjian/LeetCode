using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest415
    {
        [TestMethod]
        public void TestAddStrings()
        {
            Assert.IsTrue(AddStrings("1", "11") == "12");
            Assert.IsTrue(AddStrings("88", "22") == "110");
            Assert.IsTrue(AddStrings("123456789", "1") == "123456790");
            Assert.IsTrue(AddStrings("1111111111", "2000000000") == "3111111111");
        }

        public string AddStrings_1(string num1, string num2)
        {
            var sum = string.Empty;

            //baseStr做为循环的基础, 需要找到最长的字符串
            var baseStr = num1.Length > num2.Length ? num1 : num2;
            //plus作为加数, 使用最短的字符串
            var plusStr = num1.Length > num2.Length ? num2 : num1;

            var carry = 0;// 表示进位, 0,1

            for (int i = 0; i < baseStr.Length; i++)
            {
                var baseNumeric = int.Parse(baseStr[baseStr.Length - 1 - i].ToString());
                var plusNumeric = 0;
                if (i <= plusStr.Length - 1)
                {
                    plusNumeric = int.Parse(plusStr[plusStr.Length - 1 - i].ToString());
                }

                var current = baseNumeric + plusNumeric + carry;
                carry = current / 10;
                current = current % 10;

                sum = current + sum;
            }

            if (carry == 1)
            {
                sum = "1" + sum;
            }

            return sum;
        }

        public string AddStrings(string num1, string num2)
        {
            var sum = new StringBuilder();

            var maxLength = num1.Length > num2.Length ? num1.Length : num2.Length;

            var carry = 0;// 表示进位, 0,1

            for (int i = 0; i < maxLength; i++)
            {
                short numeric1 = 0;
                short numeric2 = 0;

                if (i < num1.Length)
                {
                    numeric1 = Convert.ToInt16(num1[num1.Length - 1 - i].ToString());
                }
                if (i < num2.Length)
                {
                    numeric2 = Convert.ToInt16(num2[num2.Length - 1 - i].ToString());
                }

                var current = numeric1 + numeric2 + carry;
                carry = current / 10;
                current = current % 10;

                sum.Insert(0, current);
            }

            if (carry == 1)
            {
                sum.Insert(0, "1");

            }

            return sum.ToString();
        }

    }
}
