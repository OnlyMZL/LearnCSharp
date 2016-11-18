using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_超市收银系统
{
    /// <summary>
    /// 不打折
    /// </summary>
    class NomalDisc : Discount
    {
        public double Rate
        {
            get;
            set;
        }
        public NomalDisc(double rate)
        {
            this.Rate = rate;
        }
        public override double ActualPay(double totalPay)
        {
            return totalPay * this.Rate;
        }
    }
}
