using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TreeViewandMenuStrip
{
    class Class1
    {

        #region  将StatusStrip控件中的信息添加到treeView控件中
        /// <summary>
        /// 读取菜单中的信息.
        /// </summary>
        /// <param name="treeV">TreeView控件</param>
        /// <param name="MenuS">MenuStrip控件</param>
        public static void GetMenu(System.Windows.Forms.TreeView treeV, MenuStrip MenuS)
        {
            //for (int i = 0; i < MenuS.Items.Count; i++) //遍历MenuStrip组件中的一级菜单项
            //{
            //    //将一级菜单项的名称添加到TreeView组件的根节点中，并设置当前节点的子节点newNode1
            //    TreeNode newNode1 = treeV.Nodes.Add(MenuS.Items[i].Text);
            //    //将当前菜单项的所有相关信息存入到ToolStripDropDownItem对象中
            //    ToolStripDropDownItem newmenu = (ToolStripDropDownItem)MenuS.Items[i];
            //    //判断当前菜单项中是否有二级菜单项
            //    if (newmenu.HasDropDownItems && newmenu.DropDownItems.Count > 0)
            //        for (int j = 0; j < newmenu.DropDownItems.Count; j++)    //遍历二级菜单项
            //        {
            //            //将二级菜单名称添加到TreeView组件的子节点newNode1中，并设置当前节点的子节点newNode2
            //            TreeNode newNode2 = newNode1.Nodes.Add(newmenu.DropDownItems[j].Text);
            //            //将当前菜单项的所有相关信息存入到ToolStripDropDownItem对象中
            //            ToolStripDropDownItem newmenu2 = (ToolStripDropDownItem)newmenu.DropDownItems[j];
            //            //判断二级菜单项中是否有三级菜单项
            //            if (newmenu2.HasDropDownItems && newmenu2.DropDownItems.Count > 0)
            //                for (int p = 0; p < newmenu2.DropDownItems.Count; p++)    //遍历三级菜单项
            //                    //将三级菜单名称添加到TreeView组件的子节点newNode2中
            //                    newNode2.Nodes.Add(newmenu2.DropDownItems[p].Text);
            //        }
            //}
            for (int i = 0; i < MenuS.Items.Count; i++)
            {
                //将一级菜单项的名称添加到TreeView组件的根节点中，并设置当前节点的子节点newNode1
                TreeNode newNode1 = treeV.Nodes.Add(MenuS.Items[i].Text);
                //将当前菜单项的所有相关信息存入到ToolStripDropDownItem对象中
                ToolStripDropDownItem newmenu = (ToolStripDropDownItem)MenuS.Items[i];
                //判断当前菜单项中是否有二级菜单项
                if (newmenu.HasDropDownItems && newmenu.DropDownItems.Count > 0)
                {
                    for (int j = 0; j < newmenu.DropDownItems.Count; j++)
                    {
                        //将二级菜单名称添加到TreeView空间子节点的newNode1中，并设置当前节点的子节点为newNode2
                        TreeNode newNode2 = newNode1.Nodes.Add(newmenu.DropDownItems[j].Text);
                        //将当前菜单项的所有相关信息存入到ToolStripDropDownItem对象中
                        ToolStripDropDownItem newmenu2 = (ToolStripDropDownItem)newmenu.DropDownItems[j];
                        //判断二级菜单项下是否有三级菜单项
                        if (newmenu2.DropDownItems.Count > 0 && newmenu2.HasDropDownItems)
                        {
                            for (int p = 0; p < newmenu2.DropDownItems.Count; p++)
                            {
                                TreeNode newNode3 = newNode2.Nodes.Add(newmenu2.DropDownItems[p].Text);
                            }
                        }
                    }
                }
            }
        }
        #endregion


        #region 窗体的调用
        /// <summary>
        /// 窗体的调用
        /// </summary>
        /// <param name="FrmName">调用窗体的Text属性值</param>
        /// <param name="n">标识</param>
        public void Show_Form(string FrmName, int n)
        {
            if (n == 1)
            {
                if (FrmName == "人事档案浏览")
                {
                    PerForm.F_ManFile FrmManFile = new PerForm.F_ManFile();
                    FrmManFile.Text = "人事档案浏览";
                    FrmManFile.ShowDialog();
                    FrmManFile.Dispose();
                }
                if (FrmName == "人事资料查询")
                {
                    PerForm.F_ManFile FrmFind = new PerForm.F_ManFile();
                    FrmFind.Text = "人事资料查询";
                    FrmFind.ShowDialog();
                    FrmFind.Dispose();
                }
                
            }
        }

        #endregion


        #region 自动编号
        public string GetAutoCoding(string TableName, string ID)
        {
            //查找指定表中ID号为最大的记录
            SqlDataAdapter MyDR = MyDataClass.getcom("select max("+ID+")NID from"+TableName);
            int Num = 0;
            if(MyDR.)
        }


        #endregion






    }
}
