using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace 操作Xml文件
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLoop_Click(object sender, RoutedEventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load(@"E:\LearnCSharp\C#Primer\操作Xml文件\操作Xml文件\Xml\XMLFile1.xml");
            XmlElement element = document.DocumentElement;
            txtResult.Text = FormatText(element as XmlNode, "", "");
        }

        private string FormatText(XmlNode node, string text, string indent)
        {
            //判断节点内容是否为标记文本
            if (node is XmlText)
            {
                text += node.Value;
                return text;
            }
            //控制缩进
            if (string.IsNullOrEmpty(indent))
            {
                indent = "";
            }
            else
            {
                text += "\r\n" + indent;
            }
            //判断是否为注释
            if (node is XmlComment)
            {
                text += node.OuterXml;
                return text;
            }
            text += "<" + node.Name;
            //判断节点属性是否为空
            if (node.Attributes.Count > 0)
            {
                AddAttributes(node, ref text);
            }
            //判断节点是否具有子节点
            if (node.HasChildNodes)
            {
                text += ">";
                foreach (XmlNode child in node.ChildNodes)
                {
                    text = FormatText(child, text, indent + " ");
                }
                if (node.ChildNodes.Count == 1 &&
                    (node.FirstChild is XmlText || node.FirstChild is XmlComment))
                {
                    text += "</" + node.Name + ">";
                }
                else
                    text += "\r\n" + indent + "</" + node.Name + ">";
            }
            else
                text += "/>";
            return text;

        }

        private void AddAttributes(XmlNode node, ref string text)
        {
            foreach (XmlAttribute xa in node.Attributes)
            {
                text += " " + xa.Name + "='" + xa.Value + "'";
            }
        }
    }
}
