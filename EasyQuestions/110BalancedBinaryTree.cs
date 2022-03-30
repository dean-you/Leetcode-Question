using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    class _110BalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {

            return GetMaxDepth(root) != -1;
        }

        private int GetMaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                int left = GetMaxDepth(root.left);
                int right = GetMaxDepth(root.right);

                if (left == -1 || right == -1 || Math.Abs(left - right) > 1) return -1;

                return Math.Max(left, right) + 1;
            }
        }
	}
}
