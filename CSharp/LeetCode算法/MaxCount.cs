using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.CSharp.LeetCode算法
{
    class Max_Count
    {
        // 不用去依次相加 再计数
        // 观察可知，最大的数必然是操作次数最多的数，找共同被ops操作到的次数就行了。即找ops数组中每一列最小值，然后相乘。
        //找出每一次都被操作到的区域的面积就可以了

        public int MaxCount(int m, int n, int[][] ops)
        {
            int mina = m, minb = n;
            foreach (int[] op in ops)
            {
                mina = Math.Min(mina, op[0]);
                minb = Math.Min(minb, op[1]);
            }
            return mina * minb;
        }
    }
}
