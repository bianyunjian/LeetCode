
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestAddTwoNumbers()
        {

            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);
            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);
            var result = AddTwoNumbers(l1, l2);

            Assert.IsTrue(GetNumber(result) == "708");

            l1 = new ListNode(5);
            l2 = new ListNode(5);
            result = AddTwoNumbers(l1, l2);
            Assert.IsTrue(GetNumber(result) == "01");

        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode resultNode = null;
            ListNode cursorForResultNode = null;
            var c1 = 0;
            var c2 = 0; 
            int upperNumericValue = 0;
            while (l1 != null || l2 != null)
            {
                if (l1 == null)
                {
                    c1 = 0;
                }
                else
                {
                    c1 = l1.val;
                }
                if (l2 == null)
                {
                    c2 = 0;
                }
                else
                {
                    c2 = l2.val;
                }
                var sum = c1 + c2 + upperNumericValue;
                upperNumericValue = sum/10;
                sum = sum % 10;
                 
                if (resultNode == null)
                {
                    resultNode = new ListNode(sum);
                    cursorForResultNode = resultNode;
                }
                else
                {
                    cursorForResultNode.next = new ListNode(sum);
                    cursorForResultNode = cursorForResultNode.next;
                }
                if (l1 != null)
                {
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    l2 = l2.next;
                }
            }
            if (upperNumericValue == 1)
            {
                cursorForResultNode.next = new ListNode(1);
            }
            return resultNode;
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public string GetNumber(ListNode listNode)
        {
            var result = string.Empty;

            var cursorNode = listNode;

            while (cursorNode != null)
            {

                result += cursorNode.val.ToString();
                cursorNode = cursorNode.next;
            }

            return result;
        }
    }
}
