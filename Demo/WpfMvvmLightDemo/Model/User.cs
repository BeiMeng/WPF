using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace WpfMvvmLightDemo.Model
{
    public class User : ObservableObject
    {
        private int _id;

        /// <summary>
        /// ID
        /// </summary>
        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
                RaisePropertyChanged("ID");
            }
        }

        private string _name;

        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }

        private string _domain;

        /// <summary>
        /// 网站域名
        /// </summary>
        public string Domain
        {
            get { return _domain; }
            set
            {
                _domain = value;
                RaisePropertyChanged("Domain");
            }
        }


        #region 模拟数据获取

        /// <summary>
        /// 模拟测试数据
        /// </summary>
        /// <returns></returns>
        public static ObservableCollection<User> GetUserList()
        {
            ObservableCollection<User> list = new ObservableCollection<User>();
            list.Add(new User() {ID = 1, Name = "王旭", Domain = "www.wxzzz.com"});
            list.Add(new User() {ID = 2, Name = "王旭博客", Domain = "www.wxzzz.com"});

            return list;
        }

        #endregion
    }
}