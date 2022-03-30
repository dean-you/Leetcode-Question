using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    class _101SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            return helper(root.left, root.right);
        }

        private bool helper(TreeNode rootLeft, TreeNode rootRight)
        {
            if (rootLeft == null && rootRight == null)
                return true;
            if (rootLeft == null || rootRight == null)
                return false;
            if (rootLeft.val != rootRight.val)
                return false;
            return helper(rootLeft.right, rootRight.left) && helper(rootLeft.left, rootRight.right);
        }

        public bool IsSymmetric_Recursive(TreeNode root)
        {
            var q = new Queue<TreeNode>();
            if (root.left == null && root.right != null)
                return false;
            if (root.left != null && root.right == null)
                return false;
            if (root.left != null)
                q.Enqueue(root.left);
            if (root.right != null)
                q.Enqueue(root.right);
            while (q.Count > 0)
            {
                var node1 = q.Dequeue();
                var node2 = q.Dequeue();
                if (node1.val != node2.val)
                    return false;

                if (node1.left == null && node2.right != null)
                    return false;
                if (node1.left != null && node2.right == null)
                    return false;
                if (node1.right == null && node2.left != null)
                    return false;
                if (node1.right != null && node2.left == null)
                    return false;

                if (node1.left != null && node2.right != null)
                {
                    q.Enqueue(node1.left);
                    q.Enqueue(node2.right);
                }

                if (node1.right != null && node2.left != null)
                {
                    q.Enqueue(node1.right);
                    q.Enqueue(node2.left);
                }
            }
            return true;
        }


    }
}
