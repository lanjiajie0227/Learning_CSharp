using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.CSharp.LeetCode算法
{
    class PhoneNumCombinations
    {
        //合并数组
        public string[] ArrayCombine(List<string[]> strList)
        {
            List<string> newString = new List<string>();
            foreach (var item in strList)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    newString.Add(item[i]);
                }
            }
            return newString.ToArray();
        }

        public IList<string> LetterCombinations(string digits)
        {
            IList<string> res = new List<string>();

            char[] digitNum = digits.ToCharArray();

            Dictionary<char, string[]> dicNumber = new Dictionary<char, string[]>();
            dicNumber.Add('2', new string[] { "a", "b", "c" });
            dicNumber.Add('3', new string[] { "d", "e", "f" });
            dicNumber.Add('4', new string[] { "g", "h", "i" });
            dicNumber.Add('5', new string[] { "j", "k", "l" });
            dicNumber.Add('6', new string[] { "m", "n", "o" });
            dicNumber.Add('7', new string[] { "p", "q", "r", "s" });
            dicNumber.Add('8', new string[] { "t", "u", "v" });
            dicNumber.Add('9', new string[] { "w", "x", "y", "z" });

            //判断约束条件和特殊情况
            switch (digits.Length)
            {
                case 0:
                    return res;
                case 1:
                    res.Add(dicNumber[digitNum[0]].ToString());
                    return res;
                case 5:
                    return res;
            }
            for (int i = 0; i < digits.Length; i++)
            {
                List<string[]> newString = new List<string[]>();
                string[] digit_one = dicNumber[digitNum[i]];
                newString.Add(digit_one);
                ArrayCombine(newString);
            }

            return res;
        }
    }
}
