using System.Data;
using System.Data.Entity.ModelConfiguration;

namespace WpfCRUDDemo.Dal.Entities.Mappings
{
    public class StudentPhotoEntityMapping : EntityTypeConfiguration<StudentPhotoEntity>
    {
        public StudentPhotoEntityMapping()
        {
            this.HasKey(t => t.StudentId);
            this.ToTable("StudentPhoto");
            this.Property(t => t.StudentPhoto).HasColumnName("StudentPhoto").HasColumnType(SqlDbType.Image.ToString()).IsRequired();
        }
    }
}