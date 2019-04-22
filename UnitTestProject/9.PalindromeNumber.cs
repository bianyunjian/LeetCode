using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest9
    {
        [TestMethod]
        public void TestPlindromeNumber()
        {
            var numberStr = 121;
            Assert.IsTrue(IsPalindrome(numberStr));

            numberStr = 0;
            Assert.IsTrue(IsPalindrome(numberStr));

            numberStr = 1;
            Assert.IsTrue(IsPalindrome(numberStr));

            numberStr = -121;
            Assert.IsTrue(IsPalindrome(numberStr)==false);
            numberStr = 10;
            Assert.IsTrue(IsPalindrome(numberStr)==false);

        }

        public bool IsPalindrome(int x)
        {
            var oldNumber = x;
            if (x < 0) { return false; }
            if (x == 0) { return true; }
            
            var newNumber = 0;
            while (x > 0)
            {
                newNumber = newNumber * 10 + x % 10;
                x = (x - x % 10) / 10;
               
            }
             
            
            return newNumber == oldNumber;
        }
    }
}
