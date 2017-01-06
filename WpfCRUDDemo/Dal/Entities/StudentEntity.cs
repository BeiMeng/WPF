namespace WpfCRUDDemo.Dal.Entities
{
    public class StudentEntity
    {
         public int StudentId { get; set; }
         public string StudentName { get; set; }
         public int StudentAge { get; set; }
         public int StudentSex { get; set; }
         public string StudentAddress { get; set; }

         public virtual StudentPhotoEntity StudentPhoto { get; set; }
    }
}