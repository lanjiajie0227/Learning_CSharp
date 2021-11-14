using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 给定一个 N 叉树，找到其最大深度。
///最大深度是指从根节点到最远叶子节点的最长路径上的节点总数。
///N 叉树输入按层序遍历序列化表示，每组子节点由空值分隔
/// </summary>
namespace Learning_CSharp.CSharp.LeetCode算法
{
    // Definition for a Node.
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
    public class NTreeMaxDeepth
    {
        public int MaxDepth(Node root)
        {
            return dfs(root);
        }
        private int dfs(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            //求各大子树的最大深度
            int res = 0;
            if (node.children != null)
            {
                foreach (Node child in node.children)
                {
                    res = Math.Max(res, dfs(child));
                }
            }
            return res + 1;
        }
    }
}
