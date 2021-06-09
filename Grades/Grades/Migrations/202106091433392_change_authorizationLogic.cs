namespace Grades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_authorizationLogic : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "PositionId", c => c.Int());
            CreateIndex("dbo.User", "PositionId");
            AddForeignKey("dbo.User", "PositionId", "dbo.Position", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "PositionId", "dbo.Position");
            DropIndex("dbo.User", new[] { "PositionId" });
            DropColumn("dbo.User", "PositionId");
        }
    }
}
