using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        }
        public int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                if (target > nums[i])
                {
                    var result1 = i;
                    var leftNumber = target - nums[i];
                    for (var j = i + 1; j < nums.Length; j++)
                    {
                        if (leftNumber == nums[j])
                        {
                            var result2 = j;
                            return new[] { result1, result2 };
                        }
                    }
                }
            }
            return new int[0];
        }
    }
}
