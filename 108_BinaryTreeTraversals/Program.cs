using System;
using System.Collections.Generic;
using System.Linq;

namespace _108_BinaryTreeTraversals
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------------ InOrder Traversal ------------");

            var output = new List<int> {1, 3, 2 };
            Console.WriteLine(Enumerable.SequenceEqual(TraversalRecursion.InOrderTraversal(Tree1()), output) ? "Passed" : "Failed");

            output = new List<int> { 6, 1, 3, 2 };
            Console.WriteLine(Enumerable.SequenceEqual(TraversalRecursion.InOrderTraversal(Tree2()), output) ? "Passed" : "Failed");

            Console.WriteLine("------------ PreOrder Traversal ------------");

            output = new List<int> { 1, 2, 3 };
            Console.WriteLine(Enumerable.SequenceEqual(TraversalRecursion.PreOrderTraversal(Tree1()), output) ? "Passed" : "Failed");

            output = new List<int> { 1, 6, 2, 3 };
            Console.WriteLine(Enumerable.SequenceEqual(TraversalRecursion.PreOrderTraversal(Tree2()), output) ? "Passed" : "Failed");

            Console.WriteLine("------------ PostOrder Traversal ------------");

            output = new List<int> { 3, 2, 1 };
            Console.WriteLine(Enumerable.SequenceEqual(TraversalRecursion.PostOrderTraversal(Tree1()), output) ? "Passed" : "Failed");

            output = new List<int> { 6, 3, 2, 1 };
            Console.WriteLine(Enumerable.SequenceEqual(TraversalRecursion.PostOrderTraversal(Tree2()), output) ? "Passed" : "Failed");

        }

        /*
         * 
               1
                \
                 2
                /
               3

         */
        static TreeNode Tree1()
        {
            return new TreeNode(
                                    1,
                                    null,
                                    new TreeNode(
                                                    2,
                                                    new TreeNode(
                                                                    3,
                                                                    null,
                                                                    null),
                                                    null)
                );
        }

        /*
         * 
                   1
                  / \
                 6   2
                    /
                   3

         */
        static TreeNode Tree2()
        {
            return new TreeNode(
                                    1,
                                    new TreeNode(
                                                    6,
                                                    null,
                                                    null),
                                    new TreeNode(
                                                    2,
                                                    new TreeNode(
                                                                    3,
                                                                    null,
                                                                    null),
                                                    null)
                );
        }

    }


    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { this.val = x; this.left = this.right = null; }
        public TreeNode(int x, TreeNode left, TreeNode right) { this.val = x; this.left = left; this.right = right; }
    }
}
