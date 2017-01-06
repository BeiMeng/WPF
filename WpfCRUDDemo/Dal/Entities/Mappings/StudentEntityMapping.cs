using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity.ModelConfiguration;

namespace WpfCRUDDemo.Dal.Entities.Mappings
{
    public class StudentEntityMapping : EntityTypeConfiguration<StudentEntity>
    {
        public StudentEntityMapping()
        {
            this.HasKey(t => t.StudentId);

            this.ToTable("Student");

            this.Property(t => t.StudentId).HasColumnName("StudentId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            this.Property(t => t.StudentName).HasColumnName("StudentName").HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(50).IsRequired();
            this.Property(t => t.StudentAge).HasColumnName("StudentAge").HasColumnType(SqlDbType.Int.ToString()).IsRequired();
            this.Property(t => t.StudentSex).HasColumnName("StudentSex").HasColumnType(SqlDbType.Int.ToString()).IsRequired();
            this.Property(t => t.StudentAddress).HasColumnName("StudentAddress").HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(200).IsRequired();

            //此配置何意？
            this.HasRequired(t => t.StudentPhoto).WithRequiredPrincipal(i => i.Student);
            this.HasOptional(t => t.StudentPhoto).WithRequired(i => i.Student);
        }
    }
}