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
    /// BindingValidation.xaml 的交互逻辑
    /// </summary>
    public partial class BindingValidation : Window
    {
        public BindingValidation()
        {
            InitializeComponent();
            Binding binding = new Binding("Value") {Source = this.Slider1};
            //Binding binding = new Binding();
            //binding.Path=new PropertyPath("Value");
            binding.UpdateSourceTrigger=UpdateSourceTrigger.PropertyChanged;   //设置当源改变时触发事件模式,设置这个意思当值改变时就改变目标值
            RangeValidationRule rangeValidationRule=new RangeValidationRule();
            rangeValidationRule.ValidatesOnTargetUpdated = true;//当源数据改变的时候也进行效验 
            binding.ValidationRules.Add(rangeValidationRule);
            binding.NotifyOnValidationError = true;//当数据效验失败时,会以目标对象为起点向外传播信号
            this.TextBox1.AddHandler(Validation.ErrorEvent, new RoutedEventHandler(this.ValidationError));//给输入框添加监听事件,事件的类型是验证错误事件,处理的方法是ValidationError
            BindingOperations.SetBinding(this.TextBox1, TextBox.TextProperty, binding);
            //this.TextBox1.SetBinding(TextBox.TextProperty, binding);
        }

        void ValidationError(object sender, RoutedEventArgs e)
        {
            var errors = Validation.GetErrors(TextBox1);
            if (errors.Count > 0)
            {
                TextBox1.ToolTip = errors[0].ErrorContent.ToString();
            }
        }
    }
}
