using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.CSharp.LeetCode算法
{
    class ChangeIntToRoman
    {
        public string IntToRoman(int num)
        {
            if (num < 1 || num > 3999)
            {
                return null;
            }
            //将几个特殊的情况的数字全部列举出来
            int[] nums = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] romans = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int index = 0;
            StringBuilder res = new StringBuilder();
            while (index < 13)
            {
                while (num >= nums[index])  //对比情况
                {
                    res.Append(romans[index]);
                    num -= nums[index];
                }
                index++;
            }
            return res.ToString();
        }
    }
}
