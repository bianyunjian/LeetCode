using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest788
    {
        [TestMethod]
        public void TestRotatedDigits()
        {
            Assert.IsTrue(RotatedDigits(10) == 4);
            Assert.IsTrue(RotatedDigits(20) == 9);
            Assert.IsTrue(RotatedDigits(857) == 247);
        }

        //X is a good number if after rotating each digit individually by 180 degrees, we get a valid number that is different from X.Each digit must be rotated - we cannot choose to leave it alone.

        //A number is valid if each digit remains a digit after rotation. 0, 1, and 8 rotate to themselves; 2 and 5 rotate to each other; 6 and 9 rotate to each other, and the rest of the numbers do not rotate to any other number and become invalid.

        //Note that 1 and 10 are not good numbers, since they remain unchanged after rotating.

        public int RotatedDigits(int N)
        {
            var validNumber = 0;
            for (int i = 1; i <= N; i++)
            {
                if (isValid(i, lastValidFlag: false)) validNumber++;

            }
            return validNumber;
        }

        private bool isValid(int i, bool lastValidFlag)
        {
            if (i == 0) return lastValidFlag;

            var d = i % 10;
            if (d == 3 || d == 4 || d == 7) return false;

            if (d == 0 || d == 1 || d == 8)
            {
                return isValid(i / 10, lastValidFlag);
            }
            return isValid(i / 10, lastValidFlag: true);
        }

        public int RotatedDigits_Char(int N)
        {
            var validNumber = 0;
            for (int i = 1; i <= N; i++)
            {
                var str = i.ToString();
                if (str.Contains("3") || str.Contains("4") || str.Contains("7"))
                {
                    continue;
                }

                // 2,5,6,9 结尾的,一定有效
                var endStr = str[str.Length - 1];
                if (endStr == '2' || endStr == '5' || endStr == '6' || endStr == '9')
                {
                    validNumber++;
                    Console.WriteLine(i);
                }

                //0,1,8 结尾的,  看前面的字符是否有 2,5,6,9
                else if (endStr == '0' || endStr == '1' || endStr == '8')
                {
                    for (int j = 0; j < str.Length - 1; j++)
                    {
                        var currentChar = str[j];
                        if (currentChar == '2' || currentChar == '5' || currentChar == '6' || currentChar == '9')
                        {
                            validNumber++;
                            Console.WriteLine(i);
                            break;
                        }
                    }
                }

            }
            return validNumber;
        }
    }
}
