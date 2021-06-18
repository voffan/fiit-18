namespace Gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dep : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Journal", "DestId", c => c.Int());
            CreateIndex("dbo.Journal", "DestId");
            AddForeignKey("dbo.Journal", "DestId", "dbo.Departament", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Journal", "DestId", "dbo.Departament");
            DropIndex("dbo.Journal", new[] { "DestId" });
            DropColumn("dbo.Journal", "DestId");
        }
    }
}
