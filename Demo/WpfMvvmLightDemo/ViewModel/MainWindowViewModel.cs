using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace WpfMvvmLightDemo.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        /********** 构造函数 ***********/
        public MainWindowViewModel()
        {
            ShowUserView = new RelayCommand(ExecuteShowUserView);
            MouseEnterCommand = new RelayCommand(ExecuteMouseEnterData);
            MouseLeaveCommand = new RelayCommand(ExecuteMouseLeaveEnterData);
        }

        

        /********** 属性 *********/
        private string _testData;

        public string TestData
        {
            get { return _testData; }
            set
            {
                _testData = value;
                RaisePropertyChanged("TestData");
            }
        }




        /********* 命令 **********/
        /// <summary>
        /// 显示UserView窗口
        /// </summary>
        public RelayCommand ShowUserView { get; private set; }

        //发送显示UserView的消息
        void ExecuteShowUserView()
        {
            Messenger.Default.Send<object>(null, "ShowUserView");
        }

        //鼠标进入事件
        public RelayCommand MouseEnterCommand { get; private set; }

        void ExecuteMouseEnterData()
        {
            TestData = "按钮鼠标进入事件绑定成功！";
        }
        //鼠标离开事件
        public RelayCommand MouseLeaveCommand { get; private set; }

        void ExecuteMouseLeaveEnterData()
        {
            TestData = "按钮鼠标离开事件绑定成功！";
        }
    }
}
