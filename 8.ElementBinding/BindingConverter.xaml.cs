using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
    /// BindingConverter.xaml 的交互逻辑
    /// </summary>
    public partial class BindingConverter : Window
    {
        public BindingConverter()
        {
            InitializeComponent();
        }

        private void ButtonLoad_OnClick(object sender, RoutedEventArgs e)
        {
            //Plane 没有实现INotifyPropertyChanged接口,属性也非依赖属性,为什么可以用binding
            List<Plane> list = new List<Plane>()
            {
                new Plane() {Category = Category.Bomber, Name = "B=1", State = State.Available},
                new Plane() {Category = Category.Fighter, Name = "B=2", State = State.Locked},
                new Plane() {Category = Category.Fighter, Name = "B=4", State = State.UnKnown},
            };
            ListBoxPlane.ItemsSource = list;
        }

        private void ButtonSave_OnClick(object sender, RoutedEventArgs e)
        {
            StringBuilder sb=new StringBuilder();
            foreach (Plane plane in ListBoxPlane.Items)
            {
                sb.AppendLine(string.Format("Category={0},Name={1},State={2}",plane.Category,plane.Name,plane.State));
            }
            File.WriteAllText(@"D:\PlantList.txt",sb.ToString());
        }
    }
}
