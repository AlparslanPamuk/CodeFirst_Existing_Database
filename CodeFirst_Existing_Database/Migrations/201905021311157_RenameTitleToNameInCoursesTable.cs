namespace CodeFirst_Existing_Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTitleToNameInCoursesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Name", c => c.String(nullable: false));
            Sql("update Courses set Name = Title");                                 //Not to lose any field
            DropColumn("dbo.Courses", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Title", c => c.String(nullable:false));
            Sql("update Courses set Title=Name");
            DropColumn("dbo.Courses", "Name");
        }
    }
}
