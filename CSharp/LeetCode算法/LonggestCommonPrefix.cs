using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 判断所有可能为""的情况，
/// strs.Length < 1 || strs.Length > 200
/// 
/// strs[i].Length < 0 || strs[i].Length > 200 || strs[i].ToString() == ""
/// 
/// !item[0].Equals(strStack.Peek()
/// 
/// 第一个字符串不是""，转换成char数组，添加进stack，循环比较，两个字符串比较一次就将结果和长度以键值对的方式存入dictionary,key => int, value => string
/// 取长度为key，最小key对应的value就是答案
/// </summary>
namespace Learning_CSharp.CSharp.LeetCode算法
{
    class LonggestCommonPrefix
    {
        //允许dictionary添加重复键值对
        public class RepeatDictionaryComparer : IEqualityComparer<int>
        {
            public bool Equals(int x, int y)
            {
                return x != y;
            }
            public int GetHashCode(int obj)
            {
                return obj.GetHashCode();
            }
        }
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length < 1 || strs.Length > 200)
            {
                return "";
            }
            if (strs.Length == 1)
            {
                return strs[0].ToString();
            }
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length < 0 || strs[i].Length > 200 || strs[i].ToString() == "")
                {
                    return "";
                }
            }

            Dictionary<int, string> dicRes = new Dictionary<int, string>(new RepeatDictionaryComparer());
            Stack<char> strStack = new Stack<char>();
            char[] strItem = strs[0].ToCharArray();

            //从第二个字符串开始，循环和
            for (int k = 1; k < strs.Length; k++)
            {
                char[] item = strs[k].ToCharArray();
                StringBuilder resBuilder = new StringBuilder();
                //将第一个字符串拆分存进char类型的栈
                for (int j = strItem.Length - 1; j >= 0; j--)
                {
                    strStack.Push(strItem[j]);
                }
                if (!item[0].Equals(strStack.Peek()))
                {
                    return "";
                }
                else
                {
                    foreach (char it in item)
                    {
                        if (strStack.Count != 0)
                        {
                            if (it.Equals(strStack.Peek()))
                            {
                                resBuilder.Append(strStack.Pop());
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    dicRes.Add(resBuilder.Length, resBuilder.ToString());
                }
                strStack.Clear();
            }
            //采用linq对dictionary中的元素进行升序排列，以key为条件排序，key为int类型，取第一个元素的value值
            string res = (from d in dicRes orderby d.Key ascending select d.Value).First().ToString();
            return res;
        }
    }
}
