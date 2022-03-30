using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    class _145BinaryTreePostOrderTraversal
    {
        /// <summary>
        /// Left, Right, Root
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var r = new List<int>();
            helper(root, r);
            return r;
        }

        private void helper(TreeNode root, List<int> list)
        {
            if (root == null)
                return;
            helper(root.left, list);
            helper(root.right, list);
            list.Add(root.val);
        }
    }
}
