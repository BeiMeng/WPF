using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _2.XamlStudy
{
    public class CodeOnlyWindow:Window
    {
        public Button NewButton;
        public CodeOnlyWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Width = this.Height = 200;
            this.Left = this.Top = 100;
            this.Title = "Code-Only Window";

            DockPanel dockPanel=new DockPanel();
            NewButton=new Button();
            Rectangle rectangle=new Rectangle();
            rectangle.Fill = Brushes.Blue;
            rectangle.Height = 10;
            rectangle.Width = 100;
            NewButton.Content = rectangle;
            NewButton.Margin=new Thickness(30);

            NewButton.Click += NewButton_Click;

            IAddChild container = dockPanel;
            container.AddChild(NewButton);

            container = this;
            container.AddChild(dockPanel);
        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("CodeOnly");
        }
    }
}
