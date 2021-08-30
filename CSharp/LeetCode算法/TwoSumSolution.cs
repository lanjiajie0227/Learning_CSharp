using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * leetcode-两数之和
 * 给定一个整数数组 nums 和一个整数目标值 target，
 * 请你在该数组中找出 和为目标值 target 的那两个整数，并返回它们的数组下标。
 * 你可以假设每种输入只会对应一个答案。但是，数组中同一个元素在答案里不能重复出现。
 * 你可以按任意顺序返回答案。
 * 
 * 暴力解法
 * 双重循环，遍历数组的一项和下一项
 */
namespace Learning_CSharp.CSharp.LeetCode算法
{
    class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            //int[] result = new int[2];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        //result[0] = i;
                        //result[1] = j;
                        return new int[] { i, j };
                    }
                }
            }
            //return result;
            return new int[0];
        }
    }
}
