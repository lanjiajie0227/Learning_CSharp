using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 检查是否大写字母正确
/// 1、全部大写
/// 2、都不是大写
/// 3、首字母大写
/// 满足上面三种情况的返回true，否则返回false
/// 用char数组接收string字符，判断是不是字符，然后判断是否大写，分别用大小写的栈保存结果
/// 对栈进行判断，符合条件就返回true
/// </summary>
namespace Learning_CSharp.CSharp.LeetCode算法
{
    class CheckUppercaseLetters
    {
        public bool DetectCapitalUse(string word)
        {
            if (word.Length > 100 || word.Length < 1)
            {
                return false;
            }
            Stack<char> Uppercase = new Stack<char>();
            Stack<char> Lowpercase = new Stack<char>();
            //转为char数组
            char[] checkArr = word.ToCharArray();
            for (int i = 0; i < checkArr.Length; i++)
            {
                if (checkArr[i] >= 65 && checkArr[i] <= 90)  //大写的ASCll码
                {
                    Uppercase.Push(checkArr[i]);
                }
                else if (checkArr[i] >= 97 && checkArr[i] <= 122)  //小写的ASCll码
                {
                    Lowpercase.Push(checkArr[i]);
                }
                else
                {
                    return false;
                }
            }
            if ((Uppercase.Count == 1 && Uppercase.Peek() == checkArr[0]) || Uppercase.Count == checkArr.Length)
            {
                return true;
            }
            else if (Lowpercase.Count == checkArr.Length)
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
