using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_超市收银系统
{
    /// <summary>
    /// 满 减 的折扣类
    /// </summary>
    class MJDisc : Discount
    {
        public double M
        {
            get;
            set;
        }
        public double J
        {
            get;
            set;
        }
        
        /// <summary>
        /// 总金额大于m时减j
        /// </summary>
        /// <param name="m">满</param>
        /// <param name="j">减</param>
        public MJDisc(double m,double j)
        {
            this.M = m;
            this.J = j;
        }

        /// <summary>
        /// 计算实际应付金额
        /// </summary>
        /// <param name="totalPay">总价</param>
        /// <returns>应付金额</returns>
        public override double ActualPay(double totalPay)
        {
            if (totalPay >= this.M)
            {
                totalPay = totalPay - (int)(totalPay / this.M) * this.J;
            }
            return totalPay;
        }

    }
}
