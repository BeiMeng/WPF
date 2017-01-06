using System.Collections.Generic;
using System.Windows.Input;
using WpfCRUDDemo.Dal;
using WpfCRUDDemo.Dal.Entities;
using WpfCRUDDemo.EventBus;
using WpfCRUDDemo.Views;

namespace WpfCRUDDemo.ViewModels
{
    public class StudentViewModel : ViewModelBase
    {
        private List<StudentEntity> _students;
        public List<StudentEntity> Students
        {
            get { return _students; }
            set
            {
                if (_students != value)
                {
                    _students = value;
                    this.OnPropertyChanged("Students");
                }
            }
        }

        private StudentEntity _studentEntity;
        public StudentEntity SelectStudentEntity
        {
            get { return _studentEntity; }
            set
            {
                if (_studentEntity != value)
                {
                    _studentEntity = value;
                    this.OnPropertyChanged("SelectStudentEntity"); 
                    //this.OnPropertyChanged<StudentEntity>(r => r.SelectStudentEntity);
                }
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand RefreshCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        private StudentDal studentDal = null;
        public StudentViewModel()
        {
            studentDal = new StudentDal();
            AddCommand = new DelegateCommand(AddStuddent);
            RefreshCommand = new DelegateCommand(Refresh);
            EditCommand = new DelegateCommand(EditStudent);
            DeleteCommand = new DelegateCommand(DeleteStudent);
            Students = new List<StudentEntity>();
            Students = studentDal.GetAllStudent();
            EventsCenter.Instance.RegisterEvent("Refresh", Refresh);
        }

        private void AddStuddent()
        {
            AddOrEditWindow addOrEditWindow = new AddOrEditWindow();
            addOrEditWindow.Show();
            var addOrEditViewModel = (addOrEditWindow.DataContext as AddOrEditViewModel);
            addOrEditViewModel.CurrentStudentEntity = new StudentEntity();
            addOrEditViewModel.IsAdd = true;
            addOrEditViewModel.StudentDal = studentDal;
        }
        private void Refresh(object param)
        {
            Students = studentDal.GetAllStudent();
        }
        private void Refresh()
        {
            Students = studentDal.GetAllStudent();
        }
        private void EditStudent()
        {
            AddOrEditWindow addOrEditWindow = new AddOrEditWindow();
            addOrEditWindow.Show();
            var addOrEditViewModel = (addOrEditWindow.DataContext as AddOrEditViewModel);
            addOrEditViewModel.CurrentStudentEntity = SelectStudentEntity;
            addOrEditViewModel.IsAdd = false;
            addOrEditViewModel.StudentDal = studentDal;
        }

        private void DeleteStudent()
        {
            studentDal.Delete(SelectStudentEntity);
            Refresh();
        }

    }
}