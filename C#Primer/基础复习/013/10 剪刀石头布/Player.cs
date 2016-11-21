using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_剪刀石头布
{
    class Player
    {
        int playerNum;

        /// <summary>
        /// 玩家出拳
        /// </summary>
        /// <param name="str">玩家选择的按钮</param>
        /// <returns></returns>
        public int PlayerFist(string str)
        {
            switch (str)
            {
                case "石头":playerNum = 1;
                    break;
                case "剪刀":playerNum = 2;
                    break;
                case "布":playerNum = 3;
                    break;
            }
            return playerNum;
        }

    }
}
