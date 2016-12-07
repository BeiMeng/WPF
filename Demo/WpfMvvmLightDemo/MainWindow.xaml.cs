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
using GalaSoft.MvvmLight.Messaging;
using WpfMvvmLightDemo.View;
using WpfMvvmLightDemo.ViewModel;

namespace WpfMvvmLightDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.DataContext = new MainWindowViewModel();
            InitializeComponent();
            //注册MVVMLight消息
            Messenger.Default.Register<object>(this, "ShowUserView", ShowUserView);

            //卸载当前(this)对象注册的所有MVVMLight消息
            //this.Unloaded += (sender, e) => Messenger.Default.Unregister(this);

            //卸载当前(this)对象注册的名为ShowUserView 的MVVMLight消息
            this.Unloaded += (sender, e) => Messenger.Default.Unregister<object>(this, "ShowUserView");
        }

        //private void BtnChangeName_Click(object sender, RoutedEventArgs e)
        //{
        //    UserView usrView = new UserView();
        //    usrView.ShowDialog();
        //}


        //弹出UserView窗体
        void ShowUserView(object obj)
        {
            UserView usrView = new UserView();
            usrView.ShowDialog();
        }
    }

}
