using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.CSharp.LeetCode算法
{
    class BulbSwitchProject
    {
        public int BulbSwitch(int n)
        {
            //int lamb = 0;
            //Dictionary<int, string> lambDic = new Dictionary<int, string>();
            //for (int i = 1; i <= n; i++)
            //{
            //    if (i == 1)
            //    {
            //        for (int j = 1; j <= n; j++)
            //        {
            //            lambDic.Add(j, "on");
            //        }
            //    }
            //    else
            //    {
            //        int k = i;
            //        if (k == n)
            //        {
            //            if (lambDic[n] == "on")
            //            {
            //                lambDic[n] = "off";
            //            }
            //            else
            //            {
            //                lambDic[n] = "on";
            //            }
            //        }
            //        else
            //        {
            //            while (k < n)
            //            {
            //                if (lambDic[k] == "on")
            //                {
            //                    lambDic[k] = "off";
            //                }
            //                else
            //                {
            //                    lambDic[k] = "on";
            //                }
            //                k += i;
            //            }
            //        }
            //    }
            //}
            //foreach (var item in lambDic)
            //{
            //    if (item.Value == "on")
            //    {
            //        lamb++;
            //    }
            //}
            //return lamb;
            return (int)Math.Sqrt(n);
        }
    }
}
