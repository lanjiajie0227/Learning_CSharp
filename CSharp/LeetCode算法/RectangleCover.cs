using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 如果是完美矩形 那么一定满足两点：
/// （1）最左下 最左上 最右下 最右上 的四个点只出现一次 其他点成对出现 
/// （2）四个点围成的矩形面积 = 所有小矩形的面积之和
///  左最小值，右最大值，上最大值，下最小值
/// </summary>
namespace Learning_CSharp.CSharp.LeetCode算法
{
    class RectangleCover
    {
        //[x,    y,     a,    b]
        //[0,    1,     2,    3]
        //[left,bottom,right,top]
        //坐标组合(x,y) (x,b)  (a,b)  (a,y)
        public bool IsRectangleCover(int[][] rectangles)
        {
            int left = int.MaxValue;//int的最大值
            int right = int.MinValue; //int的最小值
            int top = int.MinValue;
            int bottom = int.MaxValue;
            int n = rectangles.Length;

            HashSet<string> set = new HashSet<string>();
            int sumArea = 0;

            for (int i = 0; i < n; i++)
            {
                left = Math.Min(left, rectangles[i][0]);  //找出最小值
                bottom = Math.Min(bottom, rectangles[i][1]);
                right = Math.Max(right, rectangles[i][2]);  //找出最大值
                top = Math.Max(top, rectangles[i][3]);

                //所有小矩形的面积和
                sumArea += (rectangles[i][2] - rectangles[i][0]) * (rectangles[i][3] - rectangles[i][1]);

                //记录小矩形的坐标
                string lt = rectangles[i][0] + " " + rectangles[i][3];  //(x,b)
                string lb = rectangles[i][0] + " " + rectangles[i][1];  //(x,y) 
                string rt = rectangles[i][2] + " " + rectangles[i][3];   //(a,b)
                string rb = rectangles[i][2] + " " + rectangles[i][1];   //(a,y)

                //如果重复就移除，没有就加入,如果是完美矩形，最后只会剩四个坐标
                if (!set.Contains(lt))
                {
                    set.Add(lt);
                }
                else
                {
                    set.Remove(lt);
                }
                if (!set.Contains(lb))
                {
                    set.Add(lb);
                }
                else
                {
                    set.Remove(lb);
                }
                if (!set.Contains(rt))
                {
                    set.Add(rt);
                }
                else
                {
                    set.Remove(rt);
                }
                if (!set.Contains(rb))
                {
                    set.Add(rb);
                }
                else
                {
                    set.Remove(rb);
                }
            }

            if (set.Count == 4 && set.Contains(left + " " + top) && set.Contains(left + " " + bottom) && set.Contains(right + " " + top) && set.Contains(right + " " + bottom))
            {
                return sumArea == (right - left) * (top - bottom);
            }

            return false;
        }
    }
}
