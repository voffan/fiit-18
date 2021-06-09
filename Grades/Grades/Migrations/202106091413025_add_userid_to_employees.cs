namespace Grades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_userid_to_employees : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "UserId", c => c.Int());
            CreateIndex("dbo.Employee", "UserId");
            AddForeignKey("dbo.Employee", "UserId", "dbo.User", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "UserId", "dbo.User");
            DropIndex("dbo.Employee", new[] { "UserId" });
            DropColumn("dbo.Employee", "UserId");
        }
    }
}
