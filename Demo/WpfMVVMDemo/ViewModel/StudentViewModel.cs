using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfMVVMDemo.Model;
using WpfXml;

namespace WpfMVVMDemo.ViewModel
{
    public class StudentViewModel:INotifyPropertyChanged
    {

        public DelegateCommand BtnCmd { get; set; }
        public StudentViewModel()
        {
            this.BtnCmd = new DelegateCommand();
            this.BtnCmd.ExecuteCommand = new Action<object>((c) =>
            {
                this.Name = "王五";
            });
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                if (PropertyChanged != null)
                {
                    OnPropertyChanged("Name");
                }
            }
        }

        private string _sex;

        public virtual string Sex
        {
            get { return _sex; }
            set
            {
                _sex = value;
                if (PropertyChanged != null)
                {
                    OnPropertyChanged("Sex");
                }
            }
        }
        private int _age;

        public virtual int Age
        {
            get { return _age; }
            set
            {
                _age = value; 
                if (PropertyChanged != null)
                {
                    OnPropertyChanged("Age");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}