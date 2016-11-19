using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_超市收银系统
{
    /// <summary>
    /// 打折的父类
    /// </summary>
    abstract class Discount
    {
        public abstract double ActualPay(double totalPay);
    }
}
