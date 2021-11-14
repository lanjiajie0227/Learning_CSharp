using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 递归二叉树，判断每个节点是否存在左右子树
/// 左右相减取绝对值，累加所有节点坡度
/// 给定一个二叉树，计算 整个树 的坡度 。

//一个树的 节点的坡度 定义即为，该节点左子树的节点之和和右子树节点之和的 差的绝对值 。
//如果没有左子树的话，左子树的节点之和为 0 ；
//没有右子树的话也是一样。空结点的坡度是 0 。

//整个树 的坡度就是其所有节点的坡度之和。
/// </summary>
namespace Learning_CSharp.CSharp.LeetCode算法
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class FindTiltOnTreeNode
    {
        int sum = 0;
        public int FindTilt(TreeNode root) 
        {
            getSum(root);
            return sum;
        }

        public int getSum(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            int left = getSum(node.left);
            int right = getSum(node.right);
            sum += Math.Abs(left-right);   //累加所有节点坡度
            return left + right + node.val;
        }
    }
}
