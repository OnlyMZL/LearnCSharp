using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_抽象类练习_模拟电脑插入移动存储设备_
{
    class MobileDisk:RemovableStorageDevice
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘在读取数据") ;
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘在写入数据") ;
        }
    }
}
