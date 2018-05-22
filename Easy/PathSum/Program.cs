using CommonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathSum
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode t1 = new TreeNode(5);
            TreeNode t2 = new TreeNode(4);
            TreeNode t3 = new TreeNode(8);
            TreeNode t4 = new TreeNode(11);
            TreeNode t5 = new TreeNode(13);
            TreeNode t6 = new TreeNode(4);
            TreeNode t7 = new TreeNode(7);
            TreeNode t8 = new TreeNode(2);
            TreeNode t9 = new TreeNode(1);

            t6.right = t9;
            t3.right = t6;
            t3.left = t5;

            t1.right = t3;

            t4.left = t7;
            t4.right = t8;

            t2.left = t4;

            t1.left = t2;

            bool r = HasPathSum(t1, 26);
        }

        public static bool HasPathSum(TreeNode root, int sum)
        {
            if(root == null)
            {
                return false;
            }

            bool leftSum = false;
            bool rightSum = false;
            if (root.left == null && root.right == null)
            {
                return sum == root.val;
            }

            if(root.left == null && root.right != null)
            {
                return HasPathSum(root.right, sum - root.val);
            }

            if(root.left != null && root.right == null)
            {
                return HasPathSum(root.left, sum - root.val);
            }

            if(root.left != null && root.right != null)
            {
                leftSum = HasPathSum(root.left, sum - root.val);
                rightSum = HasPathSum(root.right, sum - root.val);
            }
            
            return leftSum || rightSum;
        }
    }
}
