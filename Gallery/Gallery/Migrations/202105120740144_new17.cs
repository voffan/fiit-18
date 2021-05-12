namespace Gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new17 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Journal", "DstId", "dbo.Departament");
            DropIndex("dbo.Journal", new[] { "DstId" });
            DropColumn("dbo.Journal", "DstId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Journal", "DstId", c => c.Int());
            CreateIndex("dbo.Journal", "DstId");
            AddForeignKey("dbo.Journal", "DstId", "dbo.Departament", "Id");
        }
    }
}
