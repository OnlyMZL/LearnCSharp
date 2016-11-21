using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_剪刀石头布
{

    class Computer
    {
        public int cpuNum
        {
            get;
            set;
        }
        /// <summary>
        /// 电脑出拳
        /// </summary>
        /// <returns></returns>
        public int CpuFist()
        {
            Random r = new Random();
            return this.cpuNum=r.Next(1,4);
        }

    }
}
