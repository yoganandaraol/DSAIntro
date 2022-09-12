using System;
using System.Collections.Generic;
using System.Text;

namespace _108_BinaryTreeTraversals
{
    public class TraversalRecursion
    {
        public static List<int> InOrderTraversal(TreeNode root)
        {
            var ans = new List<int>();
            InOrder(root, ans);
            return ans;
        }

        static void InOrder(TreeNode root, List<int> nodes)
        {
            var temp = root;
            if (temp == null)
            {
                return;
            }

            InOrder(temp.left, nodes);
            nodes.Add(temp.val);
            InOrder(temp.right, nodes);
        }


        public static List<int> PreOrderTraversal(TreeNode root)
        {
            var ans = new List<int>();
            PreOrder(root, ans);
            return ans;
        }

        static void PreOrder(TreeNode root, List<int> nodes)
        {
            var temp = root;
            if (temp == null)
            {
                return;
            }

            nodes.Add(temp.val);
            PreOrder(temp.left, nodes);
            PreOrder(temp.right, nodes);
        }

        public static List<int> PostOrderTraversal(TreeNode root)
        {
            var ans = new List<int>();
            PostOrder(root, ans);
            return ans;
        }

        static void PostOrder(TreeNode root, List<int> nodes)
        {
            var temp = root;
            if (temp == null)
            {
                return;
            }

            PostOrder(temp.left, nodes);
            PostOrder(temp.right, nodes);
            nodes.Add(temp.val);
        }
    }
}
