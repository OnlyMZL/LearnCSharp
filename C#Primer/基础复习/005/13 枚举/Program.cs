using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_枚举
{
    //声明枚举类型Sesons
    enum Sesons
    {
        春,
        夏,
        秋,
        冬
    }
    //声明枚举类型QQState
    enum QQState
    {
        OnLine,
        OffLine,
        Leave,
        Busy,
        QMe
    }

    class Program
    {
        static void Main(string[] args)
        {
            //使用枚举类型
            Sesons s = Sesons.夏;
            QQState state = QQState.QMe;

        }
    }
}
