using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_抽象类练习_模拟电脑插入移动存储设备_
{
    class Program
    {
        static void Main(string[] args)
        {
            //用多态来实现将 移动硬盘或者U盘或者mp3插入电脑上进行读写数据
            RemovableStorageDevice sd = new MP3();
            Computer computer = new Computer();
            computer.CRead(sd);
            computer.CWrite(sd);
            ((MP3)sd).PlayMusic();
            Console.ReadKey();
        }
    }
}
