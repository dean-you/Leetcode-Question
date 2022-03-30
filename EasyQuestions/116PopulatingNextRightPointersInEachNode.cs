using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
    class _116PopulatingNextRightPointersInEachNode
    {
        public Node Connect(Node root)
        {
            if (root == null)
                return root;
            root.next = null;
            if (root.left != null)
                Helper(root.left, root, true);
            if (root.right != null)
                Helper(root.right, root,  false);
            return root;
        }

        private void Helper(Node node, Node parent, bool bLeft)
        {
            if (bLeft)
                node.next = parent.right;
            else
            {
                if (parent.next == null)
                    node.next = null;
                else
                    node.next = parent.next.left;
            }
            if (node.left != null)
                Helper(node.left, node, true);
            if (node.right != null)
                Helper(node.right, node, false);
        }
    }
}
