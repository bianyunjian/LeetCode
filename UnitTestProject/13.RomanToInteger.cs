using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest13
    {
        [TestMethod]
        public void TestRomanToInteger()
        {
            Assert.IsTrue(RomanToInt("III") == 3);
            Assert.IsTrue(RomanToInt("IV") == 4);
            Assert.IsTrue(RomanToInt("IX") == 9);
            Assert.IsTrue(RomanToInt("LVIII") == 58);
            Assert.IsTrue(RomanToInt("MCMXCIV") == 1994);

        }
        public int RomanToInt(string s)
        {
            Dictionary<char, int> mapDic = new Dictionary<char, int>();
            mapDic.Add('I', 1);
            mapDic.Add('V', 5);
            mapDic.Add('X', 10);
            mapDic.Add('L', 50);
            mapDic.Add('C', 100);
            mapDic.Add('D', 500);
            mapDic.Add('M', 1000); 
            int number = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var val = mapDic[s[i]];
                if (i > 0)
                {
                    var previousVal = mapDic[s[i - 1]];
                    if (val > previousVal)
                    {
                        //当前字符比前面的字符要大, 需要前去前面字符
                        //因为前面已经加过该值, 所以这里需要减去双倍
                        number += val - previousVal * 2;
                    }
                    else {
                        number += val;
                    }
                }
                else
                {
                    number += val;
                }
            }

            return number;
        }
    }
}
