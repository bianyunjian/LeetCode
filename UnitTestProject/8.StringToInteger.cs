using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest8
    {
        [TestMethod]
        public void TestReverseInteger()
        {
            var numberStr = "+1";
            Assert.IsTrue(MyAtoi(numberStr) == 1);

            numberStr = "   +0 123";
            Assert.IsTrue(MyAtoi(numberStr) == 0);

            numberStr = "42";
            Assert.IsTrue(MyAtoi(numberStr) == 42);

            numberStr = "  -42";
            Assert.IsTrue(MyAtoi(numberStr) == -42);

            numberStr = "4193 with words";
            Assert.IsTrue(MyAtoi(numberStr) == 4193);

            numberStr = "words and 987";
            Assert.IsTrue(MyAtoi(numberStr) == 0);


            numberStr = "-91283472332";
            Assert.IsTrue(MyAtoi(numberStr) == int.MinValue);

            numberStr = "91283472332";
            Assert.IsTrue(MyAtoi(numberStr) == int.MaxValue);
        }

        public int MyAtoi(string str)
        {
            var longestChars = new List<char>();

            var chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ')
                {
                    if (longestChars.Count == 0)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                if ((chars[i] >= '0' && chars[i] <= '9'))
                {
                    if (longestChars.Count == 0)
                    {
                        longestChars.Add('+');
                    }

                    longestChars.Add(chars[i]);
                }
                else if (chars[i] == '-' && longestChars.Count == 0)
                {
                    longestChars.Add(chars[i]);
                }
                else if (chars[i] == '+' && longestChars.Count == 0)
                {
                    longestChars.Add(chars[i]);
                }
                else
                {
                    break;
                }
            }

            if (longestChars.Count == 0)
            {
                return 0;
            }
            foreach (var c in longestChars)
            {
                Console.Write(c);
            }

            int isPositiveNUmber = longestChars[0] == '+' ? 1 : -1;
            int maxValue = int.MaxValue / 10;
            int result = 0;
            for (int i = 1; i < longestChars.Count; i++)
            {
                var num = (longestChars[i] & 15);

                if (isPositiveNUmber == 1)
                {
                    if (result == maxValue && num > 7)
                    {
                        Console.WriteLine("Overflow");
                        return int.MaxValue;
                    }
                    if (result >= (maxValue + 1))
                    {
                        Console.WriteLine("Overflow");
                        return int.MaxValue;
                    }
                }
                if (isPositiveNUmber == -1)
                {
                    if (Math.Abs(result) == maxValue && num > 8)
                    {
                        Console.WriteLine("Overflow");
                        return int.MinValue;
                    }
                    if (Math.Abs(result) >= (maxValue + 1))
                    {
                        Console.WriteLine("Overflow");
                        return int.MinValue;
                    }
                }

                result = (result * 10) + isPositiveNUmber * num;

            }
            Console.WriteLine(result);
            return result;
        }
    }
}
