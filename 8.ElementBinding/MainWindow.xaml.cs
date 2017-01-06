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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _8.ElementBinding
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

        private void BtnFirstBindingDemo_Click(object sender, RoutedEventArgs e)
        {
            //FirstBindingDemo firstBindingDemo=new FirstBindingDemo();
            //firstBindingDemo.ShowDialog();
            //BindingValidation bindingValidation = new BindingValidation();
            //bindingValidation.ShowDialog();
            //BindingConverter bindingConverter = new BindingConverter();
            //bindingConverter.ShowDialog();
            MultiBinding multiBinding = new MultiBinding();
            multiBinding.ShowDialog();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Duration duration=new Duration(TimeSpan.FromMilliseconds(600));

            //DoubleAnimation daRx=new DoubleAnimation();
            //daRx.Duration = duration;
            //daRx.To = 400;


            //DoubleAnimationUsingKeyFrames dakGx=new DoubleAnimationUsingKeyFrames();
            //dakGx.Duration = duration;
            //SplineDoubleKeyFrame kfG=new SplineDoubleKeyFrame(400,KeyTime.FromPercent(1.0));
            //kfG.KeySpline=new KeySpline(1,0,0,1);
            //dakGx.KeyFrames.Add(kfG);

            //DoubleAnimationUsingKeyFrames dakBx = new DoubleAnimationUsingKeyFrames();
            //dakBx.Duration = duration;
            //SplineDoubleKeyFrame kfB = new SplineDoubleKeyFrame(400, KeyTime.FromPercent(1.0));
            //kfB.KeySpline = new KeySpline(1, 0, 0, 1);
            //dakBx.KeyFrames.Add(kfB);

            //Storyboard storyboard=new Storyboard();
        }
    }
}
