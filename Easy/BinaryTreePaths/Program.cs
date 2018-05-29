using CommonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreePaths
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode t7 = new TreeNode(7);
            TreeNode t6 = new TreeNode(6);
            TreeNode t5 = new TreeNode(5);
            TreeNode t4 = new TreeNode(4);
            TreeNode t3 = new TreeNode(3);
            TreeNode t2 = new TreeNode(2);
            TreeNode t1 = new TreeNode(1);

            t2.left = t4;
            t2.right = t5;

            t3.left = t6;
            t3.right = t7;

            t1.left = t2;
            t1.right = t3;

            IList<string> r = BinaryTreePaths(t1);
        }

        public static IList<string> BinaryTreePaths(TreeNode root)
        {

        }
    }
}
