using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 数字 n 代表生成括号的对数，请你设计一个函数，用于能够生成所有可能的并且 有效的 括号组合。

有效括号组合需满足：左括号必须以正确的顺序闭合。
递归，DFS深度搜索算法，满二叉树，按深度遍历所有节点并记录，移除不符合的项次
 */
namespace Learning_CSharp.CSharp.LeetCode算法
{
    class MakeFulBrackets
    {
        List<string> res = new List<string>();
        public List<string> GenerateParenthesis(int n)
        {
            if (n <= 0)
            {
                return null;
            }
            def("", 0, 0, n);
            return res;
        }

        //递归二叉树,DFS所有的路径
        public void def(string Paths, int left, int right, int n)
        {
            if (left > n || right > n)
            {
                return;
            }
            if (Paths.Length == n * 2)
            {
                res.Add(Paths);
                return;
            }
            //剪枝，不符合条件的括号
            if (left < right)
            {
                return;
            }
            def(Paths + "(", left + 1, right, n);
            def(Paths + ")", left, right + 1, n);
        }
    }
}
