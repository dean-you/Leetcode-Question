using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    class _94BinaryTreeInOrderTraversal
    {
        new List<int> r = new List<int>();
        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null)
                return r;

            InorderTraversal(root.left);
            r.Add(root.val);
            InorderTraversal(root.right);
            return r;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
