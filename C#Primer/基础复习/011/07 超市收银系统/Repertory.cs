using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_超市收银系统
{
    class Repertory
    {
        //声明集合以用来存储商品
        List<List<Goods>> list = new List<List<Goods>>();

        //构造函数  创建货架  存储不同类别的货物
        public Repertory()
        {
            list.Add(new List<Goods>());
            list.Add(new List<Goods>());
            list.Add(new List<Goods>());
            list.Add(new List<Goods>());
        }

        /// <summary>
        /// 统计仓库中的商品
        /// </summary>
        public void ShowGoods()
        {
            foreach (var item in list)
            {
                Console.WriteLine("现有商品："+item[0].Name+"\t"+"单价："+item[0].Price+"元\t"+"共有"+item.Count);
            }
        }


        /// <summary>
        /// 向仓库中进货
        /// </summary>
        /// <param name="goodsType">货物类别</param>
        /// <param name="counts">货物数量</param>
        public void GoodsIn(string goodsType, int counts)
        {
            for (int i = 0; i < counts; i++)
            {
                switch (goodsType)
                {
                    case "Acer": list[0].Add(new Acer("宏碁笔记本",4000,Guid.NewGuid().ToString()));
                        break;
                    case "SamSung":list[1].Add(new SamSung("三星手机", 3000, Guid.NewGuid().ToString()));
                        break;
                    case "Banana":list[2].Add(new Banana("香蕉", 15, Guid.NewGuid().ToString()));
                        break;
                    case "Sauce":list[3].Add(new Sauce("酱油", 10, Guid.NewGuid().ToString()));
                        break;
                }
            }
        }


        /// <summary>
        /// 从仓库中取出货物
        /// </summary>
        /// <param name="goodsType">货物类别</param>
        /// <param name="counts">货物数量</param>
        /// <returns></returns>
        public Goods[] GoodsOut(string goodsType, int counts)
        {
            Goods[] goods = new Goods[counts];
            for (int i = 0; i < counts; i++)
            {
                switch (goodsType)
                {
                    case "Acer":goods[i] =list[0][0];
                        list[0].RemoveAt(0);
                        break;
                    case "SamSung":goods[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "Banana":goods[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "Sauce":goods[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                }
            }
            return goods;
        }


    }
}
