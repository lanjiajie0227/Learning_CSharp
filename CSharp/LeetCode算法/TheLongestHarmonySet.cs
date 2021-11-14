using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 和谐数组是指一个数组里元素的最大值和最小值之间的差别 正好是 1 。
///现在，给你一个整数数组 nums ，请你在所有可能的子序列中找到最长的和谐子序列的长度。
///数组的子序列是一个由数组派生出来的序列，它可以通过删除一些元素或不删除元素、且不改变其余元素的顺序而得到。
/// </summary>
namespace Learning_CSharp.CSharp.LeetCode算法
{
    public  class TheLongestHarmonySet
    {
        public int FindLHS(int[] nums)
        {
            //先对数组进行升序排列
            Array.Sort(nums);
            int res = 0;
            int start = 0, end = 0;
            //滑动窗口，后一位减前一位，大于1，start下标往前移一位
            while (end < nums.Length)
            {
                while (nums[end] - nums[start] > 1)
                {
                    start++;
                }
                //等于1，end下标往前移一位
                if (nums[end]-nums[start]==1)
                {
                    res = Math.Max(res, end - start+1);                    
                }
                end++;
            }
            return res;
        }
    }
}
