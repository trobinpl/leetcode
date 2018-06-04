using CommonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SameTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode t13 = new TreeNode(3);
            TreeNode t12 = new TreeNode(2);
            TreeNode t11 = new TreeNode(1);
            t11.left = t12;
            t11.right = t13;

            TreeNode t23 = new TreeNode(3);
            TreeNode t22 = new TreeNode(2);
            TreeNode t21 = new TreeNode(1);
            t21.left = t22;
            t21.right = t23;

            TreeNode t32 = new TreeNode(2);
            TreeNode t31 = new TreeNode(1);
            t31.left = t32;

            TreeNode t42 = new TreeNode(2);
            TreeNode t41 = new TreeNode(1);
            t41.right = t42;

            TreeNode t53 = new TreeNode(1);
            TreeNode t52 = new TreeNode(2);
            TreeNode t51 = new TreeNode(1);
            t51.left = t52;
            t51.right = t53;

            TreeNode t63 = new TreeNode(3);
            TreeNode t62 = new TreeNode(2);
            TreeNode t61 = new TreeNode(1);
            t61.left = t62;
            t61.right = t63;

            bool r = IsSameTree(t11, t21);
            bool r2 = IsSameTree(t31, t41);
            bool r3 = IsSameTree(t51, t61);
            bool r4 = IsSameTree(null, null);
        }

        static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }

            if(p == null && q != null || p != null && q == null)
            {
                return false;
            }

            return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
