using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest15
    {
        [TestMethod]
        public void Test3Sum()
        {
            var result = ThreeSum(new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            var resultStr = string.Join(",", result[0].OrderBy(t => t).ToArray());
            Console.WriteLine(resultStr);
            Assert.IsTrue(resultStr == "0,0,0");

            result = ThreeSum(new[] { -1, 0, 1, 2, -1, -4 });
            Assert.IsTrue(result.Count == 2);
            foreach (var r in result)
            {
                resultStr = string.Join(",", r.OrderBy(t => t).ToArray());
                Console.WriteLine(resultStr);
                Assert.IsTrue(resultStr == "-1,0,1" || resultStr == "-1,-1,2");

            }


        }

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            nums = nums.OrderBy(t => t).ToArray();
            Dictionary<string, IList<int>> resultDic = new Dictionary<string, IList<int>>();

            int target = 0;
            for (int aIndex = 0; aIndex < nums.Length - 2; aIndex++)
            {
               
                if (nums[aIndex] > 0)
                {
                    break;
                }

                var bc = target - nums[aIndex];

                //find bc
                var leftIndex = aIndex + 1;
                var rightIndex = nums.Length - 1;

                while (leftIndex < rightIndex)
                {
                    if (nums[leftIndex] + nums[rightIndex] == bc)
                    { 
                        var list = new List<int>() { nums[aIndex], nums[leftIndex], nums[rightIndex] };
                        var key = nums[aIndex] + "," + nums[leftIndex] + "," + nums[rightIndex];
                        resultDic[key] = (new List<int>() { nums[aIndex], nums[leftIndex], nums[rightIndex] });

                        while (leftIndex < rightIndex && nums[leftIndex] == nums[leftIndex + 1])
                        {
                            leftIndex++;
                        }
                        leftIndex++;
                        while (leftIndex < rightIndex && nums[rightIndex] == nums[rightIndex - 1])
                        {
                            rightIndex--;
                        }
                        rightIndex--;

                    }
                    else if (nums[leftIndex] + nums[rightIndex] > bc)
                    {
                        rightIndex--;
                    }
                    else if (nums[leftIndex] + nums[rightIndex] < bc)
                    {
                        leftIndex++;
                    }
                }

            }

            return resultDic.Values.ToList();
        }
    }
}
