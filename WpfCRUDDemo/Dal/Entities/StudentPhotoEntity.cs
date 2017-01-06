namespace WpfCRUDDemo.Dal.Entities
{
    public class StudentPhotoEntity
    {
        public int StudentId { get; set; }
        public byte[] StudentPhoto { get; set; }
        public virtual StudentEntity Student { get; set; }
    }
}