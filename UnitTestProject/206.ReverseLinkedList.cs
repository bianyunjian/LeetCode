using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest206
    {


        [TestMethod]
        public void TestReverseLinkNodes()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            ListNode head = null;
            ListNode cursor = null;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (head == null)
                {
                    head = new ListNode(numbers[i]);
                    cursor = head;
                }
                else
                {
                    cursor.next = new ListNode(numbers[i]);
                    cursor = cursor.next;
                }
            }
            DumpListNode(head);

            var reversedHead = ReverseList(head);

            var result = DumpListNode(reversedHead);
            var expectStr = string.Join(' ', numbers.OrderByDescending(t => t).Select(t => t.ToString()).ToArray());

            Assert.IsTrue(result.Trim() == expectStr.Trim());
        }
        public ListNode ReverseList(ListNode head)
        {
            if (head == null) return head;
            var pHead = head;
            while (pHead.next != null)
            {
                ListNode newHeadNode = pHead.next;
                pHead.next = newHeadNode.next;
                //DumpListNode(head);
                newHeadNode.next = head;

                head = newHeadNode;
                //DumpListNode(head);
            }
            return head;
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public string DumpListNode(ListNode head)
        {
            var result = string.Empty;
            var p = head;
            while (p != null)
            {
                result += p.val + " ";
                Console.Write(p.val + " ");
                p = p.next;
            }
            Console.WriteLine();
            return result;
        }
    }
}
