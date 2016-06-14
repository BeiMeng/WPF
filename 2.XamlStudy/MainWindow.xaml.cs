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
using _2.XamlStudy.UseNotCompiledXaml;

namespace _2.XamlStudy
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

        private void CmdAnswer_OnClick(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(3));
            TxtAnswer.Text = TxtQuestion.Text;
            this.Cursor = null;
        }

        private void UserOtherNamespace_Click(object sender, RoutedEventArgs e)
        {
            UserOtherNamespaceWindow userOther=new UserOtherNamespaceWindow();
            userOther.ShowDialog();
        }

        private void OnlyCode_Click(object sender, RoutedEventArgs e)
        {
            CodeOnlyWindow codeOnly=new CodeOnlyWindow();
            codeOnly.ShowDialog();
        }

        private void UseNotCompiledXaml_Click(object sender, RoutedEventArgs e)
        {
            UseNotCompiledXamlWindow useNotCompiledXaml = new UseNotCompiledXamlWindow(AppDomain.CurrentDomain.BaseDirectory + "UseNotCompiledXaml/MyButton.xaml");
            useNotCompiledXaml.ShowDialog();
        }
    }
}
