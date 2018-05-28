using CommonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode t4 = new TreeNode(9);
            TreeNode t5 = new TreeNode(6);
            TreeNode t6 = new TreeNode(3);
            TreeNode t7 = new TreeNode(1);
            TreeNode t1 = new TreeNode(4);
            TreeNode t2 = new TreeNode(7);
            TreeNode t3 = new TreeNode(2);
            t2.left = t4;
            t2.right = t5;
            t3.left = t6;
            t3.right = t7;
            t1.left = t2;
            t1.right = t3;

            TreeNode r = InvertTree(t1);
        }

        static public TreeNode InvertTree(TreeNode root)
        {
            if(root == null)
            {
                return root;
            }

            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;

            root.left = InvertTree(root.left);
            root.right = InvertTree(root.right);

            return root;
        }
    }
}
