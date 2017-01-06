using System.Data.Entity;
using WpfCRUDDemo.Dal.Entities;

namespace WpfCRUDDemo.Dal
{
    public class StudentDataContext : DbContext
    {

        public StudentDataContext()
            : base("StudentDataContext")
        {

        }
        public DbSet<StudentEntity> Students { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(StudentDataContext).Assembly);
        }
    }
}