using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_剪刀石头布
{
    public enum Result
    {
        玩家胜,
        电脑胜,
        平局
    }
    static class Judger
    {

        /// <summary>
        /// 根据玩家和电脑出拳的结果判断胜负
        /// </summary>
        /// <param name="playerNum">玩家出拳</param>
        /// <param name="cpuNum">电脑出拳</param>
        /// <returns></returns>
        public static Result Judge(int playerNum, int cpuNum)
        {
            if (playerNum - cpuNum == -1 || playerNum - cpuNum == 2)
            {
                return Result.玩家胜;
            }
            else if (playerNum - cpuNum == 0)
            {
                return Result.平局;
            }
            else
            {
                return Result.电脑胜;
            }
        }

    }
}
