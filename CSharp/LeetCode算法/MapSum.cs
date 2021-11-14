using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
/// 实现一个键值对，可以插入数据，
/// 重复键会覆盖原来的键值对，
/// 统计相同前缀key的value值，返回总和
///
/**
 * Your MapSum object will be instantiated and called as such:
 * MapSum obj = new MapSum();
 * obj.Insert(key,val);
 * int param_2 = obj.Sum(prefix);
 */
namespace Learning_CSharp.CSharp.LeetCode算法
{
    public class MapSum
    {
        Dictionary<string, int> insertDic = new Dictionary<string, int>();   //new一个新的Dictionary对象
        public MapSum()
        {

        }
        public void Insert(string key, int val)
        {
            insertDic[key] = val;   //重复键会覆盖value值
        }
        public int Sum(string prefix)
        {
            int res = 0;
            Dictionary<string, int>.Enumerator en = insertDic.GetEnumerator();  //Dictionary的迭代器
            for (int i = 0; i < insertDic.Count; i++)
            {
                if (en.MoveNext())
                {
                    string key = en.Current.Key;  //获取当前元素的key
                    int value = en.Current.Value;  //获取当前元素的value
                    StringBuilder getPrefixFromKey = new StringBuilder();    //获取key中和prefix一样长度的字符串
                    if (prefix.Length > key.Length)   //前缀长度大于key
                    {
                        continue;
                    }
                    else if (prefix.Length < key.Length)   //前缀长度小于key
                    {
                        for (int j = 0; j < prefix.Length; j++)
                        {
                            getPrefixFromKey.Append(key.ToCharArray()[j]);
                        }
                        if (prefix.Equals(getPrefixFromKey.ToString()))    //从key中取出和prefix一样长的字符串和prefix做对比
                        {
                            res += value;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else                //前缀长度等于key 
                    {
                        if (prefix.Equals(key))
                        {
                            res += value;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

            }
            return res;
        }
    }
}
