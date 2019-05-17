using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest606
    {
        [TestMethod]
        public void TestConstructStringFromBinaryTree()
        {

            var treeNode1 = new TreeNode(1);
            treeNode1.left = new TreeNode(2);
            treeNode1.right = new TreeNode(3);
            treeNode1.left.left = new TreeNode(4);

            //      1
            //    /   \
            //  2     3
            //  /
            // 4

            Assert.IsTrue(Tree2str(treeNode1) == "1(2(4))(3)");


            var treeNode2 = new TreeNode(1);
            treeNode2.left = new TreeNode(2);
            treeNode2.right = new TreeNode(3);
            treeNode2.left.right = new TreeNode(4);

            //      1
            //    /   \
            //    2    3
            //     \  
            //      4

            Assert.IsTrue(Tree2str(treeNode2) == "1(2()(4))(3)");


            var treeNode3 = new TreeNode(1);
            treeNode3.left = new TreeNode(2);
            treeNode3.right = new TreeNode(3);
            treeNode3.left.left = new TreeNode(4);
            treeNode3.left.left.left = new TreeNode(5);
            treeNode3.right.right = new TreeNode(6);
            //      1
            //     /  \
            //    2    3
            //   /      \
            //  4        6
            // /
            //5
            Assert.IsTrue(Tree2str(treeNode3) == "1(2(4(5)))(3()(6))");
        }

        public string Tree2str(TreeNode t)
        {
            string result = string.Empty;

            if (t != null)
            {
                result += t.val.ToString();
                Console.WriteLine(result);
            }
            else
            {
                return result;

            }
            if (t.left != null)
            {
                var leftString = Tree2str(t.left);
                result += "(" + leftString + ")";
                Console.WriteLine(result);
            }
            else if (t.right != null)
            {
                result += "()";
            }

            if (t.right != null)
            {
                var rightString = Tree2str(t.right);
                result += "(" + rightString + ")";
                Console.WriteLine(result);
            }

            return result;
        }
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }

}
