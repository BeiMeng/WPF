using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _2.XamlStudy.UseNotCompiledXaml
{
    /// <summary>
    /// UseNotCompiledXamlWindow.xaml 的交互逻辑
    /// </summary>
    public partial class UseNotCompiledXamlWindow : Window
    {
        public Button NewButton;
        public UseNotCompiledXamlWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 设置MyButton.xaml的属性"复制到输出目录" 设置为始终复制，设置"生成操作" 为无
        /// </summary>
        /// <param name="xamlFile"></param>
        public UseNotCompiledXamlWindow(string xamlFile)
        {
            this.Width = this.Height = 200;
            this.Left = this.Top = 100;
            this.Title = "Dynamically Loaded XAML Window";

            DependencyObject rootElement;
            using (FileStream fs=new FileStream(xamlFile,FileMode.Open))
            {
                rootElement = (DependencyObject) XamlReader.Load(fs);
            }
            this.Content = rootElement;


            //FrameworkElement frameworkElement = (FrameworkElement) rootElement;
            //NewButton = (Button)frameworkElement.FindName("NewButton");
            //上面注释部分与下面这一句等效
            NewButton = (Button)LogicalTreeHelper.FindLogicalNode(rootElement, "NewButton");
            NewButton.Click += NewButton_Click;
        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            NewButton.Content = "谢谢你!";
        }
    }
}
