using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest7
    {
        [TestMethod]
        public void TestReverseInteger()
        {
            var number1 = 123;
            Assert.IsTrue(Reverse(number1) == 321);

            number1 = -123;
            Assert.IsTrue(Reverse(number1) == -321);

            number1 = 120;
            Assert.IsTrue(Reverse(number1) == 21);

            number1 = int.MaxValue;
            Assert.IsTrue(Reverse(number1) == 0);


            number1 = int.MinValue;
            Assert.IsTrue(Reverse(number1) == 0);

            number1 = 1563847412;
            Assert.IsTrue(Reverse(number1) == 0);
        }

        public int Reverse(int x)
        {
            int result = 0;
            while (x != 0)
            {
                if (Math.Abs(result) > (int.MaxValue / 10)) return 0;
                result = result * 10 + x % 10;
                x = x / 10;
            }

            return result;
        }

        public int Reverse_Long(int x)
        {
            if (x == int.MaxValue || x == int.MinValue) return 0;
            var isPositiveNumber = x > 0;
            var value = Math.Abs(x);

            var numList = new List<int>();

            while (value > 0)
            {
                var numeric = value % 10;
                if (numeric != 0 || numList.Count > 0)
                {
                    numList.Add(numeric);
                }
                value = (value - numeric) / 10;
            }

            //Console.Write(isPositiveNumber ? "" : "-");

            var reverseResult = 0L;
            for (int i = 0; i < numList.Count; i++)
            {
                //Console.Write(" " + numList[i]);

                var newNum = (long)(numList[i] * Math.Pow(10, numList.Count - 1 - i));
                reverseResult += newNum;
                if (reverseResult > int.MaxValue)
                {
                    //Console.Write("Overflow number");
                    return 0;
                }

            }
            reverseResult *= isPositiveNumber ? 1 : -1;
            return (int)reverseResult;
        }
    }
}
