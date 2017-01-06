namespace WpfCRUDDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studentPhoto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(nullable: false, maxLength: 50),
                        StudentAge = c.Int(nullable: false),
                        StudentSex = c.Int(nullable: false),
                        StudentAddress = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.StudentPhoto",
                c => new
                    {
                        StudentId = c.Int(nullable: false),
                        StudentPhoto = c.Binary(nullable: false, storeType: "image"),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Student", t => t.StudentId)
                .Index(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentPhoto", "StudentId", "dbo.Student");
            DropIndex("dbo.StudentPhoto", new[] { "StudentId" });
            DropTable("dbo.StudentPhoto");
            DropTable("dbo.Student");
        }
    }
}
