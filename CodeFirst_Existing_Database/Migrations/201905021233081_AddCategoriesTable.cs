namespace CodeFirst_Existing_Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            Sql("insert into Categories Values (1, 'Web Development')");
            Sql("insert into Categories Values (2, 'Programming Languages')");

        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
