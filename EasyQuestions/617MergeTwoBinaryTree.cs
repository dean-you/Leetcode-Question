using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    class _617MergeTwoBinaryTree
    {
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            TreeNode parent1 = new TreeNode();
            parent1.left = root1;
            MergeNode(root1, root2, parent1, true);
            return parent1.left;
        }

        private void MergeNode(TreeNode root1, TreeNode root2, TreeNode parent, bool left)
        {
            if (root1 != null && root2 != null)
            {
                root1.val = root1.val + root2.val;
                MergeNode(root1.left, root2.left, root1, true);
                MergeNode(root1.right, root2.right, root1, false);
            }
            else if (root2 != null)
            {
                if (left)
                    parent.left = root2;
                else
                {
                    parent.right = root2;
                }
            }
        }


        public TreeNode MergeTrees1(TreeNode root1, TreeNode root2)
        {
            if (root1 == null) return root2;
            if (root2 == null) return root1;

            return new TreeNode(root1.val + root2.val,
                MergeTrees(root1.left, root2.left),
                MergeTrees(root1.right, root2.right));
        }
    }
}
