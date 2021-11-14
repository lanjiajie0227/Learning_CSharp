using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 使用位运算
/// </summary>
namespace Learning_CSharp.CSharp.LeetCode算法
{
    class MaxTwoWords
    {
        public int MaxProduct(string[] words)
        {
            int maxValue = 0;
            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (!HasCommonWord(words[i], words[j]))
                    {
                        if (maxValue < (words[i].Length * words[j].Length))
                        {
                            maxValue = (words[i].Length * words[j].Length);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return maxValue;
        }
        //判断两个字符串是否有公共字母
        public bool HasCommonWord(string val_1, string val_2)
        {
            char[] ch = val_1.ToCharArray();
            foreach (char item in ch)
            {
                if (val_2.Contains(item.ToString()))
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }
            return false;
        }
    }
}
