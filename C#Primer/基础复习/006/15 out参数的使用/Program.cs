using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_out参数的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入用户名和密码,并判断用户名和密码是否正确
            //①如果用户名错误  提示用户  false  用户名错误 
            //②如果密码错误    提示用户  false  密码错误
            //③用户名和密码都错误   提示用户  false  用户名和密码输入错误
            //④用户名和密码输入正确  提示用户   true  登陆成功

            Console.WriteLine("请输入用户名");
            string userName = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string userPwd = Console.ReadLine();

            //方法外部使用out参数可以不赋初值
            string msg;
            bool b = IsLoginSuccess(userName, userPwd, out msg);
            Console.WriteLine("登陆信息：{0}\n提示信息：{1}",b,msg);
            Console.ReadLine();
        }

        /// <summary>
        /// 判断用户名和密码是否输入正确
        /// </summary>
        /// <param name="user">用户输入的用户名</param>
        /// <param name="pwd">用户输入的密码</param>
        /// <param name="msg">提示信息</param>
        /// <returns></returns>
        public static bool IsLoginSuccess(string user, string pwd, out string msg)
        {
            if (user == "admin" && pwd == "888888")
            {
                //方法内部使用out参数必须赋初值
                msg = "登陆成功";
                return true;
            }
            else if (user == "admin")
            {
                msg = "密码错误";
                return false;
            }
            else if (pwd == "888888")
            {
                msg = "用户名错误";
                return false;
            }
            else
            {
                msg = "用户名和密码错误";
                return false;
            }
        }
    }
}
