namespace Gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class paintingst : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Journal", "DestId", "dbo.Departament");
            DropForeignKey("dbo.Journal", "SrcId", "dbo.Departament");
            DropIndex("dbo.Journal", new[] { "SrcId" });
            DropIndex("dbo.Journal", new[] { "DestId" });
            AddColumn("dbo.Journal", "paintingStatus", c => c.Int(nullable: false));
            DropColumn("dbo.Journal", "SrcId");
            DropColumn("dbo.Journal", "DestId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Journal", "DestId", c => c.Int());
            AddColumn("dbo.Journal", "SrcId", c => c.Int());
            DropColumn("dbo.Journal", "paintingStatus");
            CreateIndex("dbo.Journal", "DestId");
            CreateIndex("dbo.Journal", "SrcId");
            AddForeignKey("dbo.Journal", "SrcId", "dbo.Departament", "Id");
            AddForeignKey("dbo.Journal", "DestId", "dbo.Departament", "Id");
        }
    }
}
