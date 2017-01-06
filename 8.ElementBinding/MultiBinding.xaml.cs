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
using System.Windows.Shapes;

namespace _8.ElementBinding
{
    /// <summary>
    /// MultiBinding.xaml 的交互逻辑
    /// </summary>
    public partial class MultiBinding : Window
    {
        public MultiBinding()
        {
            InitializeComponent();
        }

        //private void SetMultiBinding()
        //{
        //    Binding b1=new Binding("Text"){Source = this.TextBox1};
        //    Binding b2 = new Binding("Text") { Source = this.TextBox2 };
        //    Binding b3 = new Binding("Text") { Source = this.TextBox3 };

        //    MultiBinding mb = new MultiBinding() { Mode = BindingMode.OneWay };
        //    /* MultiBinding对Add顺序敏感 */
        //    mb.Bindings.Add(b1);
        //    mb.Bindings.Add(b2);
        //    mb.Bindings.Add(b3);

        //    mb.Converter = new LoginMultiConverter();

        //    ButtonOk.SetBinding(Button.IsEnabledProperty, mb);

        //}
    }
}
