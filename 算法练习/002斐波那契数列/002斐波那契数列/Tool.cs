using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002斐波那契数列
{
    class Tool   //工具类，用来传递参数
    {
        private static int inputNum;  //传递用户输入的整数
        public static int InputNum
        {
            get { return inputNum; }
            set { inputNum = value; }
        }
        private static Form1 f;  //传递窗体
        public static Form1 F
        {
            get { return f; }
            set { f = value; }
        }
    }
}
