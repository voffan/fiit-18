namespace Gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _12 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Painting", "ExhibitionId", "dbo.Exhibition");
            DropIndex("dbo.Painting", new[] { "ExhibitionId" });
            AlterColumn("dbo.Painting", "ExhibitionId", c => c.Int());
            CreateIndex("dbo.Painting", "ExhibitionId");
            AddForeignKey("dbo.Painting", "ExhibitionId", "dbo.Exhibition", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Painting", "ExhibitionId", "dbo.Exhibition");
            DropIndex("dbo.Painting", new[] { "ExhibitionId" });
            AlterColumn("dbo.Painting", "ExhibitionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Painting", "ExhibitionId");
            AddForeignKey("dbo.Painting", "ExhibitionId", "dbo.Exhibition", "Id", cascadeDelete: true);
        }
    }
}
