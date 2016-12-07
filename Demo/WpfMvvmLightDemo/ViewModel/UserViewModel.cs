using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using WpfMvvmLightDemo.Model;

namespace WpfMvvmLightDemo.ViewModel
{
    public class UserViewModel : ViewModelBase
    {
        public UserViewModel()
        {
            //初始化数据
            //_userData = User.GetUserList();
            _userData = new ObservableCollection<User>();
            //初始化命令  (第一个参数是执行的命令方法，第二个参数是控制命令是否可用)
            LoadDataCommand = new RelayCommand(ExecuteLoadDataCommand);
            AddUserCommand = new RelayCommand(ExecuteAddUser, CanExecuteAddUser);
            DeleteUserCommand = new RelayCommand(ExecuteDeleteUser, CanExecuteDeleteUser);

        }

        private ObservableCollection<User> _userData;
        /// <summary>
        /// 用户信息数据
        /// </summary>
        public ObservableCollection<User> UserData
        {
            get { return _userData; }
            set
            {
                _userData = value;
                RaisePropertyChanged("UserData");
            }
        }
        /************* 命令 ***************/
        #region 新增一个用户命令：AddUserCommand
        /// <summary>
        /// 新增一个用户
        /// </summary>
        public RelayCommand AddUserCommand { get; private set; }

        //新增一个用户 命令执行方法
        void ExecuteAddUser()
        {
            User user = new User();
            user.ID = 3;
            user.Name = "王旭";
            user.Domain = "无/" + DateTime.Now;
            UserData.Add(user);
        }

        //小于5条数据时命令可用
        bool CanExecuteAddUser()
        {
            return UserData.Count < 5;
        }
        #endregion

        #region 删除一个用户命令：DeleteUserCommand
        /// <summary>
        /// 删除一个用户
        /// </summary>
        public RelayCommand DeleteUserCommand { get; private set; }

        //删除一个用户 命令执行方法
        void ExecuteDeleteUser()
        {
            UserData.RemoveAt(0);
        }

        //最少保证有1条数据时命令可用
        bool CanExecuteDeleteUser()
        {
            return UserData.Count > 1 || UserData.Count==0;
        }
        #endregion

        #region 加载数据命令：LoadDataCommand
        /// <summary>
        /// 加载数据事件(Loading 绑定此事件)
        /// 使用 System.Windows.Interactivity.dll 中的 Interaction 可以帮助我们实现对命令的绑定，所以我们需要引用该文件到项目中，这个文件是微软的Blend中提供的
        /// 引用 System.Windows.Interactivity.dll 程序集之后，我们在 View 中添加xmlns的引用如下：
        /// xmlns:i="clr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity"
        /// </summary>
        public RelayCommand LoadDataCommand { get; private set; }

        //加载用户数据
        void ExecuteLoadDataCommand()
        {
            UserData = User.GetUserList();
        }
        #endregion
    }
}