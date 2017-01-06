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
            //����True,�����г����Զ��������ݿ⼰��ṹ
            //����Ϊfalse,�����ֶ�����update-database�������ɱ�ṹ
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
