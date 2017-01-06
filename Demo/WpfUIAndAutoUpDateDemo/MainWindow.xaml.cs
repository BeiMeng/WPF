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
using WpfUIAndAutoUpDateDemo.Base;

namespace WpfUIAndAutoUpDateDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : WindowBase
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += (sender, e) =>
            {
                this.YesButton.Content = "确 定";
                this.YesButton.Width = 60;
                this.NoButton.Content = "取 消";
                this.NoButton.Width = 60;
                this.YesButton.Click += (ss, ee) =>
                {
                    MessageBox.Show("确定");
                };
                this.NoButton.Click += (ss, ee) =>
                {
                    MessageBox.Show("取消");
                };
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
