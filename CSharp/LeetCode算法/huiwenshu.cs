using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//判断输入数字是否为回文数，可以将数字转成字符串，再翻转，对比
namespace Learning_CSharp.CSharp.LeetCode算法
{
    class huiwenshu
    {
        public bool IsPalindrome(int x)
        {
            char[] arr = x.ToString().ToCharArray();
            Array.Reverse(arr);
            StringBuilder y = new StringBuilder();
            foreach (char i in arr)
            {
                y.Append(i);
            }
            if (x.ToString() == y.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
