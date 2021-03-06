﻿using System;
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
using WpfMVVMDemo.ViewModel;

namespace WpfMVVMDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private StudentViewModel _student;
        public MainWindow()
        {
            InitializeComponent();
            this._student=new StudentViewModel{Name="张三",Sex ="男",Age=18};
            this.DataContext = _student;
        }

        private void BtnChangeName_Click(object sender, RoutedEventArgs e)
        {
            _student.Name = "李四";
        }
    }
}
