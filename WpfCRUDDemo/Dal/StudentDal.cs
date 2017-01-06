using System.Collections.Generic;
using System.Linq;
using WpfCRUDDemo.Dal.Entities;

namespace WpfCRUDDemo.Dal
{
    public class StudentDal
    {
        StudentDataContext studentDataContext = new StudentDataContext();

        public List<StudentEntity> GetAllStudent()
        {
            return studentDataContext.Students.ToList();
        }

        public void Insert(StudentEntity studentEntity)
        {
            studentDataContext.Students.Add(studentEntity);
            studentDataContext.SaveChanges();
        }
        public void Delete(StudentEntity studentEntity)
        {
            studentDataContext.Students.Remove(studentEntity);
            studentDataContext.SaveChanges();
        }
        public void Update(StudentEntity studentEntity)
        {
            var id = studentDataContext.Students.Find(studentEntity.StudentId);
            var entry = studentDataContext.Entry(id);
            entry.CurrentValues.SetValues(studentEntity);
            entry.Property(p => p.StudentId).IsModified = false;
            studentDataContext.SaveChanges();
        }
    }
}