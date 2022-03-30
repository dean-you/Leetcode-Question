using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace EasyQuestions
{
    class MinimumDepthOfBinaryTree
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            var left = root.left == null? int.MaxValue : MinDepth(root.left);
            var right = root.right == null ? int.MaxValue : MinDepth(root.right);
            if (left == int.MaxValue && right == int.MaxValue) return 1;
            return Math.Min(left, right) + 1;
        }
    }
}
