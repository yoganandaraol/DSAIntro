using System;
using System.Collections.Generic;
using System.Text;

namespace _108_BinaryTreeTraversals
{
    public class TraversalLoops
    {
        public List<int> PreOrderTraversal(TreeNode root)
        {
            var res = new List<int>();
            var temp = root;

            if (temp != null)
            {
                res.Add(temp.val);
                
            }


            return res;
        }
    }
}
