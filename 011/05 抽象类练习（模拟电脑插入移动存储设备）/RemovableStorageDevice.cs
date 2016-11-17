using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_抽象类练习_模拟电脑插入移动存储设备_
{
    public abstract class RemovableStorageDevice
    {
        public abstract void Read();
        public abstract void Write();
    }
}
