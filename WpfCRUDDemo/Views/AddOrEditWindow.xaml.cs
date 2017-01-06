using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfCRUDDemo.ViewModels;

namespace WpfCRUDDemo.Views
{
    /// <summary>
    /// AddOrEditWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AddOrEditWindow : Window
    {
        public AddOrEditWindow()
        {
            InitializeComponent();
            AddOrEditViewModel addOrEditViewModel = new AddOrEditViewModel();
            //addOrEditViewModel.CloseViewHandlerEvent += addOrEditViewModel_CloseViewHandlerEvent;
            //addOrEditViewModel.CloseViewHandlerEvent+=(() =>
            //{
            //    this.Close();
            //});
            addOrEditViewModel.CloseViewHandlerEvent += this.Close;
            this.DataContext = addOrEditViewModel;
        }

        void addOrEditViewModel_CloseViewHandlerEvent()
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
