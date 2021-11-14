using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.CSharp.CSharp设计模式.单例模式
{
    public class Singleton
    {
        //私有变量记录Singleton的唯一实例
        private static Singleton uniqueInstance;

        //创建锁保证线程同步
        private static readonly object locker = new object();

        //私有构造函数
        private Singleton()
        {

        }

        //定义一个公有方法来提供该类唯一的全局访问点
        public static Singleton GetInstance()
        {
            //双重锁定，先判断是否为空，不为空则不锁，直接返回，减少了锁的开销
            if (uniqueInstance == null)
            {
                lock (locker)
                {
                    //如果实例不存在则new一个新实例，否则返回已有实例
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new Singleton();
                    }
                }
            }
            return uniqueInstance;
        }
    }
}
