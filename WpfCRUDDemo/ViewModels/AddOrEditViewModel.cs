using System;
using System.Drawing;
using System.IO;
using System.Windows.Input;
using Microsoft.Win32;
using WpfCRUDDemo.Dal;
using WpfCRUDDemo.Dal.Entities;
using WpfCRUDDemo.EventBus;

namespace WpfCRUDDemo.ViewModels
{
    //定义委托
 public delegate void CloseViewHandler();
 public class AddOrEditViewModel :ViewModelBase
 {
        //定义事件
        //public event CloseViewHandler CloseViewHandlerEvent;
        public event Action CloseViewHandlerEvent;
        private StudentEntity _currentStudentEntity;
        public StudentEntity CurrentStudentEntity
        {
            get { return _currentStudentEntity; }
            set 
            {
                if (_currentStudentEntity != value)
                {
                    _currentStudentEntity = value;
                    if (_currentStudentEntity.StudentSex == 0)
                    {
                        IsChecked = true;
                    }
                    else
                    {
                        IsChecked = false ;
                    }

                    this.OnPropertyChanged("CurrentStudentEntity");
                }
            }
        }

        private bool _isChecked;
        public bool IsChecked
        {
            get { return _isChecked; }
            set
            {
                if (_isChecked != value)
                {
                    _isChecked = value;
                    this.OnPropertyChanged("IsChecked");
                }
            }
        }

        public StudentDal StudentDal { get; set; }

        private bool _isAdd = false;

        public bool IsAdd
        {
            get { return _isAdd; }
            set
            {
                if (_isAdd != value)
                {
                    _isAdd = value;
                    this.OnPropertyChanged("IsAdd");
                }
            }
        }
        public ICommand SaveCommand { get; set; }
        public ICommand UpLoadImgCommand { get; set; }

        public AddOrEditViewModel()
        {
            SaveCommand = new DelegateCommand(Save);
            UpLoadImgCommand = new DelegateCommand(UpLoadImg);
        }

        private void UpLoadImg()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            //过滤上传图片的类型  
            ofd.Filter = "jpg图片|*.jpg|png图片|*.png|jpeg图片|*.jpeg|bmp图片|*.bmp";
            if (ofd.ShowDialog() == true)
            {
                string fileName = ofd.FileName;
                var d = File.ReadAllBytes(fileName);
                //Image img = new Image();
                StudentPhotoEntity studentPhoto=new StudentPhotoEntity();
                CurrentStudentEntity.StudentPhoto = studentPhoto;
                CurrentStudentEntity.StudentPhoto.StudentPhoto = File.ReadAllBytes(fileName);
                ////读取文件的二进制数据  
                //img.ImageContent = File.ReadAllBytes(fileName);
                //img.ImageName = fileName;
            }  
        }

        private void Save()
        {
            StudentEntity student = new StudentEntity();
            student.StudentName = CurrentStudentEntity.StudentName;
            student.StudentAge = CurrentStudentEntity.StudentAge;
            student.StudentSex = IsChecked ?0:1;
            student.StudentAddress = CurrentStudentEntity.StudentAddress;
            StudentPhotoEntity studentPhoto = new StudentPhotoEntity()
            {
                StudentPhoto = CurrentStudentEntity.StudentPhoto.StudentPhoto
            };
            student.StudentPhoto = studentPhoto;
            if (IsAdd)
            {
                StudentDal.Insert(student);
            }
            else
            {
                student.StudentId = CurrentStudentEntity.StudentId;
                student.StudentPhoto.StudentId = CurrentStudentEntity.StudentId;
                StudentDal.Update(student);
            }
            //引发事件，关闭窗体
            if (CloseViewHandlerEvent != null)
            {
                CloseViewHandlerEvent();
            }
            EventsCenter.Instance.TriggerEvent("Refresh", "测试参数");
        }
    }
}