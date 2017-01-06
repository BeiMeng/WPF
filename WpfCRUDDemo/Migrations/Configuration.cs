namespace WpfCRUDDemo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WpfCRUDDemo.Dal.StudentDataContext>
    {
        public Configuration()
        {
            //设置True,则运行程序自动生成数据库及表结构
            //设置为false,则需手动键入update-database命令生成表结构
            AutomaticMigrationsEnabled = true;
            ContextKey = "BeiDreamWpf";
        }

        protected override void Seed(WpfCRUDDemo.Dal.StudentDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
