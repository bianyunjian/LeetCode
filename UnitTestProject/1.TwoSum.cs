using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTwoSum()
        {
            var result = TwoSum(new[] { 2, 7, 9, 11 }, 9);

            Assert.IsTrue(result.Length == 2 && result[0] == 0 && result[1] == 1);

            result = TwoSum(new[] { 3, 2, 4 }, 6);
            Assert.IsTrue(result.Length == 2 && result[0] == 1 && result[1] == 2);

            result = TwoSum_Dic(new[] { -1, -2, -3, -4, -5 }, -8);
            Assert.IsTrue(result.Length == 2 && result[0] == 2 && result[1] == 4);
            result = TwoSum_Dic(new[] { 2, 2, 3, 4 }, 4);
            Assert.IsTrue(result.Length == 2 && result[0] == 0 && result[1] == 1);

        }
        public int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (target - nums[i] == nums[j])
                    {
                        return new[] { i, j };
                    }
                }

            }
            return new int[0];
        }


        public int[] TwoSum_Dic(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var matchNumber = target - nums[i];
                if (dic.ContainsKey(matchNumber))
                {
                    return new[] { dic[matchNumber], i };
                }
                dic[nums[i]] = i;
            }
            return new int[0];
        }
    }
}
