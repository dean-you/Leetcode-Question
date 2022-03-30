using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    class _112PathSum
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
                return false;
            if (root.val == targetSum && root.left == null && root.right == null)
                return true;
            targetSum = targetSum - root.val;
            return HasPathSum(root.left, targetSum) || HasPathSum(root.right, targetSum);
        }
    }
}
