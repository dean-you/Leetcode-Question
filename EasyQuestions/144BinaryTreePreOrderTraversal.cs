using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    class _144BinaryTreePreOrderTraversal
    {
        /// <summary>
        /// Root, Left, Right
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var r = new List<int>();
            helper(root, r);
            return r;
        }

        private void helper(TreeNode root, List<int> list)
        {
            if (root == null)
                return;
            list.Add(root.val);
            helper(root.left, list);
            helper(root.right, list);
        }
    }
}
