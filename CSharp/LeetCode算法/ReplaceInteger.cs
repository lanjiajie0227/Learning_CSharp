using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 使用位运算
/// </summary>
namespace Learning_CSharp
{
    public class ReplaceInteger
    {
        public int IntegerReplacement(int n)
        {
            int res = 0;
            //判断n为偶数或者为奇数
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    if(n%4==1||n==3)
                    {
                        n--;
                    }
                    else
                    {
                        n++;
                    }
                }
                res++;
            }
            return res;
        }
    }
}
