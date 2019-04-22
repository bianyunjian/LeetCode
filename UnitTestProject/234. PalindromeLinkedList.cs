using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest234
    {
        [TestMethod]
        public void TestPalindromeLinkedList()
        {
            ListNode node1 = new ListNode(1);
            Assert.IsTrue(IsPalindrome(node1));

            node1 = new ListNode(1);
            node1.next = new ListNode(2);
            Assert.IsTrue(IsPalindrome(node1) == false);

            node1 = new ListNode(1);
            node1.next = new ListNode(2);
            node1.next.next = new ListNode(2);
            node1.next.next.next = new ListNode(1);
            Assert.IsTrue(IsPalindrome(node1));

            node1 = new ListNode(1);
            node1.next = new ListNode(2);
            node1.next.next = new ListNode(3);
            node1.next.next.next = new ListNode(2);
            node1.next.next.next.next = new ListNode(1);
            Assert.IsTrue(IsPalindrome(node1));

            node1 = new ListNode(1);
            node1.next = new ListNode(2);
            node1.next.next = new ListNode(3);
            node1.next.next.next = new ListNode(2);
            node1.next.next.next.next = new ListNode(2);
            Assert.IsTrue(IsPalindrome(node1) == false);


            node1 = new ListNode(1);
            node1.next = new ListNode(2);
            node1.next.next = new ListNode(3);
            node1.next.next.next = new ListNode(3);
            node1.next.next.next.next = new ListNode(2);
            node1.next.next.next.next.next = new ListNode(1);
            Assert.IsTrue(IsPalindrome(node1));
        }

        
        public bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null) return true;

            ListNode fastCursor = head, slowCursor = head;

            while (fastCursor.next != null && fastCursor.next.next != null)
            {
                fastCursor = fastCursor.next.next;
                slowCursor = slowCursor.next;
            }

            ListNode pHead = slowCursor.next, pre = head;
            while (pHead.next != null)
            {
                ListNode newHeadNode = pHead.next;
                pHead.next = newHeadNode.next;
                DumpListNode(head);
                newHeadNode.next = slowCursor.next;
                DumpListNode(head);
                slowCursor.next = newHeadNode;
                DumpListNode(head);
            }


            while (slowCursor.next != null)
            {
                slowCursor = slowCursor.next;
                if (pre.val != slowCursor.val) return false;
                pre = pre.next;
            }
            return true;
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public void DumpListNode(ListNode head)
        {
            var p = head;
            while (p != null)
            {
                Console.Write(p.val + " ");
                p = p.next;
            }
            Console.WriteLine();

        }
    }
}
