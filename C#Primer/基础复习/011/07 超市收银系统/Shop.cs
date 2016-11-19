using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_超市收银系统
{
    class Shop
    {
        Repertory rep = new Repertory();

        //构造函数，向仓库中进货
        public Shop()
        {
            rep.GoodsIn("Acer", 200);
            rep.GoodsIn("SamSung", 200);
            rep.GoodsIn("Banana", 300);
            rep.GoodsIn("Sauce", 100);
        }

        public void AskBuying()
        {
            rep.ShowGoods();
            Console.WriteLine("欢迎光临，本商店有Acer、SamSung、Banana、Sauce");
            Console.WriteLine("请问您需要什么?");
            string good = Console.ReadLine();
            Console.WriteLine("请问您需要多少?");
            int count = Convert.ToInt32(Console.ReadLine());
            //从仓库中取商品
            Goods[] goods = rep.GoodsOut(good, count);
            //计算总价
            double totalPay = TotalPay(goods);
            //选择折扣种类，并计算出应付金额
            Console.WriteLine("您享有以下折扣类型： 1--无折扣  2--九折  3--八五折  4--满300减50  5--满500减100");
            string discountWay = Console.ReadLine();
            //通过简单工厂设计模式根据用户的输入获得一个打折对象
            Discount disct = GetDiscount(discountWay);
            double actualpay= disct.ActualPay(totalPay);
            Console.WriteLine("应付{0}元",actualpay);
            //获得账单
            GetBill(goods,actualpay);
        }

        /// <summary>
        /// 根据商品和数量计算未打折的价格
        /// </summary>
        /// <param name="goods">商品数组</param>
        /// <returns></returns>
        public static double TotalPay(Goods[] goods)
        {
            double totalpay = 0;
            foreach (var item in goods)
            {
                totalpay = item.Price * goods.Length;
            }
            return totalpay;
        }


        /// <summary>
        /// 根据用户选择的打折类型创建打折对象的方法
        /// </summary>
        /// <param name="i">用户选择的打折方式</param>
        /// <returns></returns>
        public static Discount GetDiscount(string i)
        {
            Discount d = null;
            switch (i)
            {
                case "1":
                    d = new NomalDisc(1);
                    break;
                case "2":
                    d = new NomalDisc(0.9);
                    break;
                case "3":
                    d = new NomalDisc(0.85);
                    break;
                case "4":
                    d = new MJDisc(300, 50);
                    break;
                case "5":
                    d = new MJDisc(500, 100);
                    break;
            }
            return d;
        }

        /// <summary>
        /// 获得购物清单
        /// </summary>
        /// <param name="goods">商品数组</param>
        public static void GetBill(Goods[] goods,double pay)
        {
            Console.WriteLine("您的购物清单");
            Console.WriteLine("====================================================");
            Console.WriteLine("商品：{0}----{1}元/件",goods[0].Name,goods[0].Price);
            Console.WriteLine("共{0}件，应付{1}元",goods.Length,pay);
        }


    }
}
