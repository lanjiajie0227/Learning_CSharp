using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///二分法,不能使用三层循环,三数之和为0的
/// </summary>
namespace Learning_CSharp.CSharp.LeetCode算法
{
    class ThreeNumberSum
    {
        //IList是接口，使用时需要先实现接口
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();   //实现IList接口
            Array.Sort(nums); //排序
            if (nums.Length < 3)   //如果元素数少于3个，返回空的
            {
                return res;
            }
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                int k = nums.Length - 1;
                for (int j = i + 1; j < k; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }
                    if ((nums[i] + nums[j] + nums[k]) == 0)
                    {
                        int[] resNum = { nums[i], nums[j], nums[k] };
                        Array.Sort(resNum);
                        res.Add(resNum);
                    }
                    else if ((nums[i] + nums[j] + nums[k]) > 0)
                    {
                        j--;
                        k--;
                    }
                }
            }
            return res;
        }
    }
}
