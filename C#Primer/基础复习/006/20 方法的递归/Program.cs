using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_方法的递归
{
    class Program
    {
        static void Main(string[] args)
        {
            TellStory();
            Console.ReadLine();
        }

        /// <summary>
        /// 讲故事
        /// </summary>
        public static int i = 0;
        public static void TellStory()
        {
            Console.WriteLine("从前有座山，\n山里有座庙，\n庙里有个老和尚和小和尚，\n有一天小和尚哭了，老和尚给小和尚讲了一个故事"+i);
            i++;
            if (i < 10)
            {
                TellStory();
            }
        }
    }
}
