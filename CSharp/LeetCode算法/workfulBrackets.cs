using Nito.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串 s ，判断字符串是否有效。
///有效字符串需满足：
///左括号必须用相同类型的右括号闭合。
///左括号必须以正确的顺序闭合。
//来源：力扣（LeetCode）
//链接：https://leetcode-cn.com/problems/valid-parentheses
///著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
/// </summary>
/// 这题可以使用stack来做
///

namespace Learning_CSharp.CSharp.LeetCode算法
{
    class workfulBrackets
    {
        public bool IsValid(string s)
        {
            //如果长度是奇数直接返回错误
            int n = s.Length;
            if (n % 2 == 1)
            {
                return false;
            }

            //定义保存的栈
            Stack<char> st = new Stack<char>();
            char ch;
            for (int i = 0; i < s.Length; i++)
            {
                ch = s.ToCharArray()[i];
                if (ch == '(')
                {
                    st.Push(')');
                }
                else if (ch == '{')
                {
                    st.Push('}');
                }
                else if (ch == '[')
                {
                    st.Push(']');
                }
                else if (st.Count == 0 || st.Peek() != ch)
                {
                    return false;
                }
                else
                {
                    st.Pop();
                }
            }
            return st.Count == 0;
        }
    }
}
