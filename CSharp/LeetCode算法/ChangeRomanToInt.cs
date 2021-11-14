using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 罗马数字转换成阿拉伯数字
/// 使用键值对存储特殊位置的罗马数字以及罗马数字对应的阿拉伯数字
/// 对于罗马数字s，将字符s拆分为char类型的数组，从char数组最后一个字符开始往前面比较，
/// 和前一位元素对应的阿拉伯数字作比较，大于或等于则加上当前值，否则减去当前值
/// </summary>
namespace Learning_CSharp.CSharp.LeetCode算法
{
    class ChangeRomanToInt
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> hash = new Dictionary<char, int>();
            hash.Add('I', 1);
            hash.Add('V', 5);
            hash.Add('X', 10);
            hash.Add('L', 50);
            hash.Add('C', 100);
            hash.Add('D', 500);
            hash.Add('M', 1000);
            char[] sToChar = s.ToCharArray();
            int res = hash[sToChar[sToChar.Length - 1]];
            for (int i = sToChar.Length - 2; i >= 0; i--)
            {
                if (hash[sToChar[i]] >= hash[sToChar[i + 1]])
                {
                    res += hash[sToChar[i]];
                }
                else
                {
                    res -= hash[sToChar[i]];
                }
            }
            return res;
        }
    }
}
