using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    class _104MaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            var cur = new List<TreeNode>();
            List<TreeNode> next;
            var count = 0;
            if (root == null)
                return 0;
            cur.Add(root);
            while (cur.Count > 0)
            {
                next = new List<TreeNode>(cur);
                cur = new List<TreeNode>();
                count++;
                foreach (var n in next)
                {
                    if (n.left != null)
                        cur.Add(n.left);
                    if (n.right != null)
                        cur.Add(n.right);
                }
            }
            return count;
        }
    }
}
